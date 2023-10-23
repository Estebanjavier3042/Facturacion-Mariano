using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Provincia
{
    public int CodigoProv { get; set; }

    public string? DescripcionProv { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
