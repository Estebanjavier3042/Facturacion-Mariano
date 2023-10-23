using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Sexo")]
    public class SexoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public SexoController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(SexoCreacionDTO sexoCreacionDTO )
        {
            var nuevo = mapper.Map<Sexo>(sexoCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Sexo>>> Get()
        {
            var sexo = await bdMinimarketContext.Sexos.ToListAsync();

            return Ok(sexo);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.Sexos.Where(a => a.CodigoSx == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionSx = des;
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
            var actual = await bdMinimarketContext.Sexos.Where(a => a.CodigoSx == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }

}
