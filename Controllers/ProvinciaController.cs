using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Provincia")]
    public class ProvinciaController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public ProvinciaController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(ProvinciaCreacionDTO provinciaCreacionDTO)
        {
            var nuevo = mapper.Map<Provincia>(provinciaCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Provincia>>> Get()
        {
            var provincias = await bdMinimarketContext.Provincias.ToListAsync();

            return Ok(provincias);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put1(int cod, string des)
        {
            var anterior = await bdMinimarketContext.Provincias.Where(a => a.CodigoProv == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionProv = des;
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
            var actual = await bdMinimarketContext.Provincias.Where(a => a.CodigoProv == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
