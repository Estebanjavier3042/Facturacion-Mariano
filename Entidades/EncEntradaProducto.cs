using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace baseDatosMariano.Entidades;

public partial class EncEntradaProducto
{
    public int CodigoEp { get; set; }
   
    public int CodigoTde { get; set; }
    public int CodigoAl { get; set; }

    public string? NrodocumentoEp { get; set; }

    public int CodigoPv { get; set; }

    public DateTime? FechaEp { get; set; }

    public string? ObservacionEp { get; set; }

    public decimal Subtotal { get; set; } = 0;

    public decimal Iva { get; set; } = 0;

    public decimal TotalImporte { get; set; }= 0;

    public DateTime? FechaCrea { get; set; }

    public bool? Estado { get; set; }

    public virtual Almacene CodigoAlNavigation { get; set; } = null!;

    public virtual Proveedore CodigoPvNavigation { get; set; } = null!;

    public virtual TiposDocumentosEmitir CodigoTdeNavigation { get; set; } = null!;
    public virtual List<DetEntradaProducto> DetEntradaProductos { get; set; } = null!;

}
