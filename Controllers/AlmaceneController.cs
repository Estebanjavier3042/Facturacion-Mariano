using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Almacen")]
    public class AlmaceneController : ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public AlmaceneController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(AlmaceneCreacionDTO almaceneCreacionDTO)
        {
            var almacen = mapper.Map<Almacene>(almaceneCreacionDTO);
            bdMinimarketContext.Add(almacen);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Almacene>>> Get()
        {
            var almacene = await bdMinimarketContext.Almacenes.Select(al => new
            {
                Id = al.CodigoAl,
                NombreSucursal = al.DescripcionAl,
                Estado = al.Estado,
            }).ToListAsync();
            return Ok(almacene);
        }
        [HttpGet("Por nombre")]
        public async Task<ActionResult<IEnumerable<Almacene>>>Get(string nombre)
        {
            var almacenes =  await bdMinimarketContext.Almacenes.Where(a=>a.DescripcionAl.Contains(nombre)).ToListAsync();
            var almacen =almacenes.Select(al => new
            {
                Id = al.CodigoAl,
                NombreSucursal = al.DescripcionAl,
                Estado = al.Estado,
            }).ToList();
            return Ok(almacen);
        }
        [HttpPut("Codigo")]
        public async Task<ActionResult> Put(int cod,string descripcion )
        {
            var anterior= await bdMinimarketContext.Almacenes.Where(a=>a.CodigoAl==cod).FirstOrDefaultAsync();
            if (anterior!=null)
            {
                anterior.DescripcionAl = descripcion;
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
            var actual=await bdMinimarketContext.Almacenes.Where(a=>a.CodigoAl==cod).ExecuteDeleteAsync();
            if (actual!=0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
