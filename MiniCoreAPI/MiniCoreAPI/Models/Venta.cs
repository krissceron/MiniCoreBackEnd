using System;
using System.Collections.Generic;

namespace MinicoreCompras.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int IdVendedor { get; set; }

    public string Ventas { get; set; } = null!;

    public int Monto { get; set; }

    public DateTime FechaVenta { get; set; }

    public virtual Vendedor IdVendedorNavigation { get; set; } = null!;
}
