using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class StockProducto
{
    public int CodigoPr { get; set; }

    public int CodigoAl { get; set; }

    public decimal? StockActual { get; set; }

    public decimal? PuCompra { get; set; }

    public virtual Almacene CodigoAlNavigation { get; set; } = null!;

    public virtual Producto CodigoPrNavigation { get; set; } = null!;
}
