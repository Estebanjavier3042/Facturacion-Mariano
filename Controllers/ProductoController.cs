using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Producto")]
    public class ProductoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public ProductoController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(ProductoCreacionDTO productoCreacionDTO )
        {
            var producto = mapper.Map<Producto>(productoCreacionDTO);
            bdMinimarketContext.Add(producto);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {
            
            var filtro =await bdMinimarketContext.Productos.Select(p => new
            {
                Codigo = p.CodigoPr,
                Nombre = p.DescripcionPr,
                CategoriA = p.CodigoCaNavigation.DescripcionCa,
                StockMinimo = p.StockMin,
                StockMaxino = p.StockMax,
                StockActual = p.StockProductos.Select(sp => sp.StockActual )
            }).ToListAsync();
            return Ok(filtro);
        }
        [HttpGet("Por Descripcion")]
        public async Task<ActionResult<IEnumerable<Producto>>> Get1(string descrip)
        {

            var filtro = await bdMinimarketContext.Productos
                .Where(p => p.DescripcionPr.Contains(descrip)).Select(r => new
            {
                Codigo = r.CodigoPr,
                Nombre = r.DescripcionPr,
                CategoriA = r.CodigoCaNavigation.DescripcionCa,
                StockMinimo = r.StockMin,
                StockMaxino = r.StockMax,
                StockActual = r.StockProductos.Select(sp =>sp.StockActual )
            }).ToListAsync();
            return Ok(filtro);
        }
        [HttpGet("Por Codigo")]
        public async Task<ActionResult<IEnumerable<Producto>>> Get2(int cod)
        {

            var filtro = await bdMinimarketContext.Productos
                .Where(p => p.CodigoPr==cod).Select(r => new
                {
                    Codigo = r.CodigoPr,
                    Nombre = r.DescripcionPr,
                    CategoriA = r.CodigoCaNavigation.DescripcionCa,
                    StockMinimo = r.StockMin,
                    StockMaxino = r.StockMax,
                    StockActual = r.StockProductos.Select(sp => sp.StockActual)
                }).ToListAsync();
            return Ok(filtro);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Productos.Where(a => a.CodigoPr == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionPr = descripcion;
            }
            else
            {
                return NotFound();
            }
            bdMinimarketContext.Update(anterior);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("ELimanar por Codigo")]
        public async Task<ActionResult> Delete(int cod)
        {
            var actual = await bdMinimarketContext.Productos.Where(a => a.CodigoPr == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }

    }
}
