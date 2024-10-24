namespace MinicoreCompras.Models
{
    public class ReporteVentas
    {
        public List<Ventas> ListaVentas { get; set; }

        public ReporteVentas()
        {
            ListaVentas = new List<Ventas>();
        }
    }
    public class Ventas
    {
        public string NombreVendedor { get; set; }
        public int MontoTotal { get; set; }
    }
}
