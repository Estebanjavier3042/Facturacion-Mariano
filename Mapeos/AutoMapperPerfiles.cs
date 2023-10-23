using AutoMapper;
using baseDatosMariano.DTO;
using baseDatosMariano.Entidades;

namespace baseDatosMariano.Mapeos
{
    public class AutoMapperPerfiles : Profile
    {
        public AutoMapperPerfiles()
        {
            CreateMap<AlmaceneCreacionDTO, Almacene>();
            CreateMap<CategoriaCreacionDTO, Categoria>();
            CreateMap<CiudadeCreacionDTO, Ciudade>();
            CreateMap<DetEntradaProductoCreacionDTO, DetEntradaProducto>();
            CreateMap<EncEntradaProductoCreacionDTO, EncEntradaProducto>();
            CreateMap<MarcaCreacionDTO, Marca>();
            CreateMap<ProductoCreacionDTO, Producto>();
            CreateMap<ProveedoreCreacionDTO, Proveedore>();
            CreateMap<ProvinciaCreacionDTO, Provincia>();
            CreateMap<RubroCreacionDTO, Rubro>();
            CreateMap<SexoCreacionDTO, Sexo>();
            CreateMap<StockProductoCreacionDTO, StockProducto>();
            CreateMap<TiposDocumentoPvClCreacionDTO, TiposDocumentoPvCl>();
            CreateMap<TiposDocumentosEmitirCreacionDTO, TiposDocumentosEmitir>();
            CreateMap<UnidadesMedidaCreacionDTO, UnidadesMedida>();
            CreateMap<DepartamentoCreacionDTO, Departamento>();
        }
    }
}
