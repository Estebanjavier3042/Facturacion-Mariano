using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace baseDatosMariano.Entidades;

public partial class DetEntradaProducto
{
    

    public int CodigoEp { get; set; }

    public int CodigoPr { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PuCompra { get; set; }

    public decimal Total { get; set; }


    public virtual EncEntradaProducto EncEntradaProducto { get; set; } = null!;
   
}
