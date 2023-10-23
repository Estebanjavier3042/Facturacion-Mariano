using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    
    [Route("Api/DetEntrada Producto")]
    public class DetEntradaProductoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public DetEntradaProductoController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(DetEntradaProductoCreacionDTO detEntradaProductoCreacionDTO)
        {
            var detEntradaProducto = mapper.Map<DetEntradaProducto>(detEntradaProductoCreacionDTO);
            bdMinimarketContext.Add(detEntradaProducto);
       

            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<DetEntradaProducto>> Get(int codigoFactura)
        {
            var DetEnPro = await bdMinimarketContext.DetEntradaProductos
                .Where(d => d.CodigoEp == codigoFactura).ToListAsync();

            return Ok(DetEnPro);
        }

    }
}
