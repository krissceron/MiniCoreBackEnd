using System;
using System.Collections.Generic;

namespace MinicoreCompras.Models;

public partial class Vendedor
{
    public int IdVendedor { get; set; }

    public string NombreVendedor { get; set; } = null!;

    public virtual ICollection<Venta> Ventas { get; } = new List<Venta>();
}
