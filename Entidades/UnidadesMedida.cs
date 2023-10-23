using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class UnidadesMedida
{
    public int CodigoUm { get; set; }

    public string? AbreviaturaUm { get; set; }

    public string? DescripcionUm { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
