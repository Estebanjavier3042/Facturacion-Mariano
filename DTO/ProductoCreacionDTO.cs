using baseDatosMariano.Entidades;

namespace baseDatosMariano.DTO
{
    public class ProductoCreacionDTO
    {
        public string? DescripcionPr { get; set; }

        public int CodigoMa { get; set; }

        public int CodigoUm { get; set; }

        public int CodigoCa { get; set; }

        public decimal? StockMin { get; set; }

        public decimal? StockMax { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaModifica { get; set; }

        public bool Estado { get; set; }
        public List<StockProductoCreacionDTO> StockProductos { get; set; } = new List<StockProductoCreacionDTO>();
    }
}
