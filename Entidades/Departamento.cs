using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Departamento
{
    public int CodigoDe { get; set; }

    public string? DescripcionDe { get; set; }

    public int CodigoProv { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Ciudade> Ciudades { get; set; } = new List<Ciudade>();

    public virtual Provincia CodigoProvNavigation { get; set; } = null!;
}
