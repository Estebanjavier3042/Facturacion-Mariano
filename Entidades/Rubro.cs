using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Rubro
{
    public int CodigoRu { get; set; }

    public string? DescripcionRu { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
