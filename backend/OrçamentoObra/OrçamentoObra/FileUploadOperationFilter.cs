using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace OrçamentoObra.Swagger
{
    public class FileUploadOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var fileParams = context.ApiDescription.ParameterDescriptions
                .Where(p => p.ParameterDescriptor != null &&
                            (p.ParameterDescriptor.ParameterType == typeof(IFormFile) ||
                             typeof(List<IFormFile>).IsAssignableFrom(p.ParameterDescriptor.ParameterType)))
                .ToList();

            if (fileParams.Any())
            {
                foreach (var fileParam in fileParams)
                {
                    var fileParamName = fileParam.Name;

                    operation.RequestBody = new OpenApiRequestBody
                    {
                        Content = new Dictionary<string, OpenApiMediaType>
                        {
                            {
                                "multipart/form-data", new OpenApiMediaType
                                {
                                    Schema = new OpenApiSchema
                                    {
                                        Type = "object",
                                        Properties = new Dictionary<string, OpenApiSchema>
                                        {
                                            {
                                                fileParamName, new OpenApiSchema
                                                {
                                                    Type = "string",
                                                    Format = "binary"
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                }
            }
        }
    }
}