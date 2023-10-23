using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Almacene
{
    public int CodigoAl { get; set; }

    public string? DescripcionAl { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<EncEntradaProducto> EncEntradaProductos { get; set; } = new List<EncEntradaProducto>();
    public List<StockProducto> StockProductos { get; set; } = new List<StockProducto>();
}
