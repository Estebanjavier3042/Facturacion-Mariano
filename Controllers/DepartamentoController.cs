using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Departamento")]
    public class DepartamentoController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public DepartamentoController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(DepartamentoCreacionDTO departamentoCreacionDTO)
        {
            var departamento = mapper.Map<Departamento>(departamentoCreacionDTO);
            bdMinimarketContext.Add(departamento);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> Get()
        {
            var final = await bdMinimarketContext.Departamentos.Select(al => new
            {
                Id = al.CodigoDe,
                Departamento = al.DescripcionDe,
                Estado = al.Estado,
            }).ToListAsync();
            return Ok(final);
        }
        [HttpGet("Por nombre")]
        public async Task<ActionResult<IEnumerable<Departamento>>> Get(string nombre)
        {
            var item = await bdMinimarketContext.Departamentos.Where(a => a.DescripcionDe .Contains(nombre)).ToListAsync();
            var Final = item.Select(al => new
            {
                Id = al.CodigoDe,
                Departamento = al.DescripcionDe,
                Estado = al.Estado,
            }).ToList();
            return Ok(Final);
        }
        [HttpPut("Codigo")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Departamentos.Where(a => a.CodigoDe == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DescripcionDe = descripcion;
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
            var actual = await bdMinimarketContext.Departamentos.Where(a => a.CodigoDe == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
