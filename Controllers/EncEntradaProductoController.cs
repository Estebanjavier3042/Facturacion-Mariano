using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/EncEntrada Producto")]
    public class EncEntradaProductoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public EncEntradaProductoController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost("productos existentes")]
        public async Task<ActionResult> Post(EncEntradaProductoCreacionDTO encEntradaProductoCreacionDTO)
        {
           
            var encEntradaProducto = mapper.Map<EncEntradaProducto>(encEntradaProductoCreacionDTO);
           // encEntradaProducto.Subtotal = 0;
            var prod = encEntradaProducto.DetEntradaProductos;
            var stockAL = encEntradaProducto.CodigoAl;
            for (int i = 0; i < prod.Count; i++)
            {
                decimal cantidad = prod[i].Cantidad;
                decimal PrecioUni = prod[i].PuCompra; 
                encEntradaProducto.Subtotal += (PrecioUni * cantidad);
                prod[i].Total = (PrecioUni * cantidad);

                var stock = await bdMinimarketContext.StockProductos
                .Where(p => p.CodigoPr == prod[i].CodigoPr & p.CodigoAl==stockAL).FirstOrDefaultAsync();
                
                if (stock!=null)
                {
                    stock.StockActual = stock.StockActual + cantidad;

                }
               
                

            }
            
            encEntradaProducto.Iva = encEntradaProducto.Subtotal * 0.21M;
            encEntradaProducto.TotalImporte = encEntradaProducto.Iva + encEntradaProducto.Subtotal;
            bdMinimarketContext.Add(encEntradaProducto);

            bdMinimarketContext.Add(encEntradaProducto);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("productos nuevos")]
        public async Task<ActionResult> Post1(EncEntradaProductoCreacionDTO encEntradaProductoCreacionDTO)
        {

            var encEntradaProducto = mapper.Map<EncEntradaProducto>(encEntradaProductoCreacionDTO);
            // encEntradaProducto.Subtotal = 0;
            var prod = encEntradaProducto.DetEntradaProductos;
            var stockAL = encEntradaProducto.CodigoAl;
            for (int i = 0; i < prod.Count; i++)
            {
                decimal cantidad = prod[i].Cantidad;
                decimal PrecioUni = prod[i].PuCompra;
                encEntradaProducto.Subtotal += (PrecioUni * cantidad);
                prod[i].Total = (PrecioUni * cantidad);

                var stock = await bdMinimarketContext.StockProductos
                .Where(p => p.CodigoPr == prod[i].CodigoPr & p.CodigoAl == stockAL).FirstOrDefaultAsync();

                if (stock != null)
                {
                    stock.StockActual = stock.StockActual + cantidad;

                }
                else
                {


                }


            }

            encEntradaProducto.Iva = encEntradaProducto.Subtotal * 0.21M;
            encEntradaProducto.TotalImporte = encEntradaProducto.Iva + encEntradaProducto.Subtotal;
            bdMinimarketContext.Add(encEntradaProducto);

            bdMinimarketContext.Add(encEntradaProducto);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<EncEntradaProducto>> Get(string Dni)
        {
            var final = await bdMinimarketContext.EncEntradaProductos
                .Where(e => e.NrodocumentoEp.Equals(Dni)).ToListAsync();
            var final1= final.Select(e => new 
            { 
              CodigoEp=e.CodigoEp,
              DocumentoNro=e.NrodocumentoEp,
              Descripion=e.ObservacionEp,
              Iva=e.Iva,
              Subtotal=e.Subtotal,
              TotalImporte=e.TotalImporte,
              e.FechaCrea
            }).ToList();
            return Ok(final1);

        }
        [HttpGet("Compras Mayores a")]
        public async Task<ActionResult<EncEntradaProducto>> Get(int compra)
        {
            var final = await bdMinimarketContext.EncEntradaProductos
                .Where(e => e.TotalImporte > compra).ToListAsync();
            var final1 = final.Select(e => new
            {
                CodigoEp = e.CodigoEp,
                DocumentoNro = e.NrodocumentoEp,
                Descripion = e.ObservacionEp,
                Iva = e.Iva,
                Subtotal = e.Subtotal,
                TotalImporte = e.TotalImporte,
                e.FechaCrea
            }).ToList();
            return Ok(final1);

        }

    }
}
