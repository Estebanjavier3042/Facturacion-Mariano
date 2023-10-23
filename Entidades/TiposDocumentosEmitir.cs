using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class TiposDocumentosEmitir
{
    public int CodigoTde { get; set; }

    public string? DescripcionTde { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<EncEntradaProducto> EncEntradaProductos { get; set; } = new List<EncEntradaProducto>();
}
