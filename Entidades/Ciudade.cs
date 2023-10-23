using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Ciudade
{
    public int CodigoCi { get; set; }

    public string? DescripcionCi { get; set; }

    public int CodigoDe { get; set; }

    public bool? Estado { get; set; }

    public virtual Departamento CodigoDeNavigation { get; set; } = null!;

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
