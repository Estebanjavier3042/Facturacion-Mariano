using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Marca
{
    public int CodigoMa { get; set; }

    public string? DescripcionMa { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
