using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class TiposDocumentoPvCl
{
    public int CodigoTdpc { get; set; }

    public string? DescripcionTdpc { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
