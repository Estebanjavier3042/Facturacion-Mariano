using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Marca")]
    public class MarcaController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public MarcaController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(MarcaCreacionDTO marcaCreacionDTO)
        {
            var marca = mapper.Map<Marca>(marcaCreacionDTO);
            bdMinimarketContext.Add(marca);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marca>>> Get()
        {
            var final = await bdMinimarketContext.Marcas.Select(al => new
            {
                Id = al.CodigoMa,
                Nombre = al.DescripcionMa,
                Estado = al.Estado,
            }).ToListAsync();
            return Ok(final);
        }
        [HttpGet("Por nombre")]
        public async Task<ActionResult<IEnumerable<Marca>>> Get(string nombre)
        {
            var item = await bdMinimarketContext.Marcas.Where(a => a.DescripcionMa.Contains(nombre)).ToListAsync();
            var Final = item.Select(al => new
            {
                Id = al.CodigoMa ,
                Nombre = al.DescripcionMa,
                Estado = al.Estado,
            }).ToList();
            return Ok(Final);
        }
        [HttpPut("Codigo")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Marcas.Where(a => a.CodigoMa == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionMa = descripcion;
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
            var actual = await bdMinimarketContext.Marcas.Where(a => a.CodigoMa == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
