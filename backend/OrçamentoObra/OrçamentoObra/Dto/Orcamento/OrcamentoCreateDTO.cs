using System.ComponentModel.DataAnnotations;

namespace OrçamentoObra.Dto.Orcamento
{
    public class OrcamentoCreateDTO
    {
        [Required(ErrorMessage = "Informe o nome do Orçamento")]
        public string Nome { get; set; }
        public int ClienteId { get; set; }
    }
}
