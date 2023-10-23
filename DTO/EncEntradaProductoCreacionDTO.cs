using baseDatosMariano.Entidades;

namespace baseDatosMariano.DTO
{
    public class EncEntradaProductoCreacionDTO
    {
        public int CodigoTde { get; set; }

        public string? NrodocumentoEp { get; set; }

        public int CodigoPv { get; set; }

        public DateTime? FechaEp { get; set; }

        public int CodigoAl { get; set; }

        public string? ObservacionEp { get; set; }

        //public decimal? Subtotal { get; set; }

        //public decimal? Iva { get; set; }

        //public decimal? TotalImporte { get; set; }
        public virtual List<DetEntradaProductoCreacionDTO> DetEntradaProductos { get; set; } = null!;

        public DateTime? FechaCrea { get; set; }

        public bool? Estado { get; set; }

    }
}
