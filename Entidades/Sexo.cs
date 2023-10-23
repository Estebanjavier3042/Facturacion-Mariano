using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Sexo
{
    public int CodigoSx { get; set; }

    public string? DescripcionSx { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
