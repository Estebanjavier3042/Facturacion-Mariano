using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Stock Producto")]
    public class StockProductoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public StockProductoController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(StockProductoCreacionDTO stockProductoCreacionDTO )
        {
            var nuevo = mapper.Map<StockProducto>(stockProductoCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
    }
}
