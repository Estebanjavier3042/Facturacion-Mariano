using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Rubro")]
    public class RubroController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public RubroController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(RubroCreacionDTO rubroCreacionDTO )
        {
            var nuevo = mapper.Map<Rubro>(rubroCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Rubro>>> Get()
        {
            var rubro = await bdMinimarketContext.Rubros.ToListAsync();

            return Ok(rubro);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.Rubros.Where(a => a.CodigoRu == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionRu = des;
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
            var actual = await bdMinimarketContext.Rubros.Where(a => a.CodigoRu == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
