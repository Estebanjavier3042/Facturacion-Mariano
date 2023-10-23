using System;
using System.Collections.Generic;

namespace baseDatosMariano.Entidades;

public partial class Proveedore
{
    public int CodigoPv { get; set; }

    public int CodigoTdpc { get; set; }

    public string? DocumentoPv { get; set; }

    public string? RazonSocialPv { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public int CodigoSx { get; set; }

    public int CodigoRu { get; set; }

    public string? EmailPv { get; set; }

    public string? TelefonoPv { get; set; }

    public string? MovilPv { get; set; }

    public string? DireccionPv { get; set; }

    public int CodigoCi { get; set; }

    public string? ObservacionPv { get; set; }

    public DateTime? FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool? Estado { get; set; }

    public virtual Ciudade CodigoCiNavigation { get; set; } = null!;

    public virtual Rubro CodigoRuNavigation { get; set; } = null!;

    public virtual Sexo CodigoSxNavigation { get; set; } = null!;

    public virtual TiposDocumentoPvCl CodigoTdpcNavigation { get; set; } = null!;

    public virtual ICollection<EncEntradaProducto> EncEntradaProductos { get; set; } = new List<EncEntradaProducto>();
}
