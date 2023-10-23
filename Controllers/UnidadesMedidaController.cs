using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Unidades de Medida")]
    public class UnidadesMedidaController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public UnidadesMedidaController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(UnidadesMedidaCreacionDTO unidadesMedidaCreacionDTO )
        {
            var nuevo = mapper.Map<UnidadesMedida>(unidadesMedidaCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadesMedida>>> Get()
        {
            var unidades = await bdMinimarketContext.UnidadesMedidas.ToListAsync();

            return Ok(unidades);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.UnidadesMedidas.Where(a => a.CodigoUm == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionUm = des;
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
            var actual = await bdMinimarketContext.UnidadesMedidas.Where(a => a.CodigoUm == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
