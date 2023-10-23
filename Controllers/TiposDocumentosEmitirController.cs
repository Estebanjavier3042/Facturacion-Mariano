using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Tipos Documentos Emitir")]
    public class TiposDocumentosEmitirController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public TiposDocumentosEmitirController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(TiposDocumentosEmitirCreacionDTO tiposDocumentosEmitirCreacionDTO )
        {
            var nuevo = mapper.Map<TiposDocumentosEmitir>(tiposDocumentosEmitirCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposDocumentosEmitir>>> Get()
        {
            var tiposDoc = await bdMinimarketContext.TiposDocumentosEmitirs.ToListAsync();

            return Ok(tiposDoc);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.TiposDocumentosEmitirs.Where(a => a.CodigoTde == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionTde = des;
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
            var actual = await bdMinimarketContext.TiposDocumentoPvCls.Where(a => a.CodigoTdpc == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
