using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Data.Entity;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Tipos Documentos PvCl")]
    public class TiposDocumentoPvClController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public TiposDocumentoPvClController(BdMinimarketContext bdMinimarketContext,IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(TiposDocumentoPvClCreacionDTO tiposDocumentoPvClCreacionDTO )
        {
            var nuevo = mapper.Map<TiposDocumentoPvCl>(tiposDocumentoPvClCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposDocumentoPvCl>>> Get()
        {
            var tiposDoc = await bdMinimarketContext.TiposDocumentoPvCls.ToListAsync();

            return Ok(tiposDoc);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.TiposDocumentoPvCls.Where(a => a.CodigoTdpc == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionTdpc = des;
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
