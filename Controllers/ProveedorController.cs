using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baseDatosMariano.Controllers
{
    [ApiController]
    [Route("Api/Proveedor")]
    public class ProveedorController:ControllerBase
    {
        private readonly BdMinimarketContext bdMinimarketContext;
        private readonly IMapper mapper;

        public ProveedorController(BdMinimarketContext bdMinimarketContext, IMapper mapper)
        {
            this.bdMinimarketContext = bdMinimarketContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(ProveedoreCreacionDTO proveedoreCreacionDTO)
        {
            var nuevo = mapper.Map<Proveedore>(proveedoreCreacionDTO);
            bdMinimarketContext.Add(nuevo);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("Documento")]
        public async Task<ActionResult<IEnumerable<Proveedore>>>Get(string doc)
        {
            var proveedor = await bdMinimarketContext.Proveedores.Where(p=>p.DocumentoPv.Equals(doc)).ToListAsync();
            var filtro = proveedor.Select(pr => new
            {
                Codigo=pr.CodigoPv,
                Nombre =pr.Nombres,
                Apellido =pr.Apellidos,
                Direccion =pr.DireccionPv,
                Email=pr.EmailPv,
                Telefono=pr.TelefonoPv,
                Movil=pr.MovilPv,
                Observaciones=pr.ObservacionPv
            }).ToList();
            return Ok(filtro);
        }
        [HttpGet("Nombre")]
        public async Task<ActionResult<IEnumerable<Proveedore>>> Get1(string nombre)
        {
            var proveedor = await bdMinimarketContext.Proveedores.Where(p => p.Nombres.Equals(nombre)).ToListAsync();
            var filtro = proveedor.Select(pr => new
            {
                Codigo = pr.CodigoPv,
                Nombre = pr.Nombres,
                Apellido = pr.Apellidos,
                Direccion = pr.DireccionPv,
                Email = pr.EmailPv,
                Telefono = pr.TelefonoPv,
                Movil = pr.MovilPv,
                Observaciones = pr.ObservacionPv
            }).ToList();
            return Ok(filtro);
        }
        [HttpGet("Apellido")]
        public async Task<ActionResult<IEnumerable<Proveedore>>> Get2(string apellido)
        {
            var proveedor = await bdMinimarketContext.Proveedores.Where(p => p.Apellidos.Equals(apellido)).ToListAsync();
            var filtro = proveedor.Select(pr => new
            {
                Codigo = pr.CodigoPv,
                Nombre = pr.Nombres,
                Apellido = pr.Apellidos,
                Direccion = pr.DireccionPv,
                Email = pr.EmailPv,
                Telefono = pr.TelefonoPv,
                Movil = pr.MovilPv,
                Observaciones = pr.ObservacionPv
            }).ToList();
            return Ok(filtro);
        }
        [HttpGet("Codigo de Proveedor")]
        public async Task<ActionResult<IEnumerable<Proveedore>>> Get2(int cod)
        {
            var proveedor = await bdMinimarketContext.Proveedores.Where(p => p.CodigoPv.Equals(cod)).ToListAsync();
            var filtro = proveedor.Select(pr => new
            {
                Codigo = pr.CodigoPv,
                Nombre = pr.Nombres,
                Apellido = pr.Apellidos,
                Direccion = pr.DireccionPv,
                Email = pr.EmailPv,
                Telefono = pr.TelefonoPv,
                Movil = pr.MovilPv,
                Observaciones = pr.ObservacionPv
            }).ToList();
            return Ok(filtro);
        }
        [HttpPut("Cambio Descripcion")]
        public async Task<ActionResult> Put(int cod, string descripcion)
        {
            var anterior = await bdMinimarketContext.Proveedores.Where(a => a.CodigoPv == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DireccionPv = descripcion;
            }
            else
            {
                return NotFound();
            }
            bdMinimarketContext.Update(anterior);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("Cambio Documento")]
        public async Task<ActionResult> Put1(int cod, string doc)
        {
            var anterior = await bdMinimarketContext.Proveedores.Where(a => a.CodigoPv == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.DocumentoPv = doc;
            }
            else
            {
                return NotFound();
            }
            bdMinimarketContext.Update(anterior);
            await bdMinimarketContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("Cambio Nombre y Apellido")]
        public async Task<ActionResult> Put2(int cod, string nombre,string apellido)
        {
            var anterior = await bdMinimarketContext.Proveedores.Where(a => a.CodigoPv == cod).FirstOrDefaultAsync();
            if (anterior != null)
            {
                anterior.Nombres = nombre;
                anterior.Apellidos= apellido;
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
            var actual = await bdMinimarketContext.Proveedores.Where(a => a.CodigoPv == cod).ExecuteDeleteAsync();
            if (actual != 0)
            {
                return Ok();
            }

            return NotFound();
        }

    }
}
