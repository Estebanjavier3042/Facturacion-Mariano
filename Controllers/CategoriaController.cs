using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public CategoriaController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(CategoriaCreacionDTO categoriaCreacionDTO)
        {
            var categoria = mapper.Map<Categoria>(categoriaCreacionDTO);
            bdMinimarketContext.Add(categoria);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get()
        {
            var final = await bdMinimarketContext.Categorias.Select(al => new
            {
                Id = al.CodigoCa,
                Descripcion = al.DescripcionCa,
                Estado = al.Estado,
            }).ToListAsync();
            return Ok(final);
        }
        [HttpGet("Por nombre")]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get(string nombre)
        {
            var item = await bdMinimarketContext.Categorias.Where(a => a.DescripcionCa.Contains(nombre)).ToListAsync();
            var Final = item.Select(al => new
            {
                Id = al.CodigoCa,
                Descrpcion = al.DescripcionCa,
                Estado = al.Estado,
            }).ToList();
            return Ok(Final);
        }
        [HttpPut("Codigo")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Categorias.Where(a => a.CodigoCa == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionCa = descripcion;
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
            var actual = await bdMinimarketContext.Categorias.Where(a => a.CodigoCa == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
