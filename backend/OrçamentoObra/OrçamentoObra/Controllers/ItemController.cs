using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrçamentoObra.Dto.Item;
using OrçamentoObra.Services.Interface;

namespace OrçamentoObra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemInterface _itemInterface;

        public ItemController(IItemInterface item)
        {
            _itemInterface = item;
        }

        [HttpPost]
        public async Task<IActionResult> CriarItem([FromBody] ItemCreateDTO itemCreateDTO)
        {
            var item = await _itemInterface.CriarItem(itemCreateDTO);
            return Ok(item);
        }

        [HttpGet("")]
        public IActionResult ListarItems()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarItem([FromBody] ItemUpdateDTO itemUpdateDTO)
        {
            var item = await _itemInterface.EditarItem(itemUpdateDTO);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverItem(int id)
        {
            var item = await _itemInterface.ExcluirItem(id);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarItemPorId(int id)
        {
            var item = await _itemInterface.BuscarItemPorId(id);
            return Ok(item);
        }

        [HttpGet("categoria/{categoriaId}")]
        public async Task<IActionResult> ListarItemPorCategoria(int categoriaId)
        {
            var item = await _itemInterface.ListarItemPorCategoria(categoriaId);
            return Ok(item);
        }
    }
}