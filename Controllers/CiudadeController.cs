using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Ciudades")]
    public class CiudadeController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public CiudadeController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(CiudadeCreacionDTO cuidadeCreacionDTO)
        {
            var ciudade = mapper.Map<Ciudade>(cuidadeCreacionDTO);
            bdMinimarketContext.Add(ciudade);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudade>>> Get()
        {
            var final = await bdMinimarketContext.Ciudades.Select(al => new
            {
                Id = al.CodigoCi,
                Ciudad = al.DescripcionCi,
                Estado = al.Estado,
            }).ToListAsync();
            return Ok(final);
        }
        [HttpGet("Por nombre")]
        public async Task<ActionResult<IEnumerable<Ciudade>>> Get(string nombre)
        {
            var item = await bdMinimarketContext.Ciudades.Where(a => a.DescripcionCi.Contains(nombre)).ToListAsync();
            var Final = item.Select(al => new
            {
                Id = al.CodigoCi,
                Ciudad = al.DescripcionCi,
                Estado = al.Estado,
            }).ToList();
            return Ok(Final);
        }
        [HttpPut("Codigo")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Ciudades.Where(a => a.CodigoCi == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionCi = descripcion;
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
            var actual = await bdMinimarketContext.Ciudades.Where(a => a.CodigoCi == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
