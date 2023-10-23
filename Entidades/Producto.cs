using baseDatosMariano.DTO;
using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Producto
{
    public int CodigoPr { get; set; }

    public string? DescripcionPr { get; set; }

    public int CodigoMa { get; set; }

    public int CodigoUm { get; set; }

    public int CodigoCa { get; set; }

    public decimal? StockMin { get; set; }

    public decimal? StockMax { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Estado { get; set; }

    public virtual Categoria CodigoCaNavigation { get; set; } = null!;

    public virtual Marca CodigoMaNavigation { get; set; } = null!;

    public virtual UnidadesMedida CodigoUmNavigation { get; set; } = null!;
    public List<StockProducto> StockProductos { get; set; } = new List<StockProducto>();
}
