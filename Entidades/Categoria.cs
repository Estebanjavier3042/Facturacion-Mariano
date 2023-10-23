using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Categoria
{
    public int CodigoCa { get; set; }

    public string? DescripcionCa { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
