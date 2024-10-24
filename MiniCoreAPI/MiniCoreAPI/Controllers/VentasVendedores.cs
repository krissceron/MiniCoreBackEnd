using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinicoreCompras.Models;

namespace MinicoreCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasVendedores : ControllerBase
    {
        private readonly MiniCoreVentasContext _context;

        public VentasVendedores(MiniCoreVentasContext context)
        {
            _context = context;
        }
        // GET: Minicorecompras
        [HttpGet(Name = "~/GetReporteventas")]
        public async Task<ReporteVentas> GetReporteventas(DateTime FechaInicio, DateTime FechaFin)
        {


            var contexto = (from cr in _context.Ventas.Where(cr => cr.FechaVenta >= FechaInicio && cr.FechaVenta <= FechaFin)
                            join cl in _context.Vendedores on cr.IdVendedor equals cl.IdVendedor
                            select new
                            {
                                idVendedor = cr.IdVendedor,
                                NombreVendedor = cl.NombreVendedor,
                                MontoVendedor = cr.Monto,
                            }).ToList();


            var listaVendedores = contexto.Select(r => r.idVendedor).Distinct().ToList();
            var modelo = new ReporteVentas();

            foreach (var obj in listaVendedores)
            {
                var venta = new Ventas();
                var VentasVendedor = contexto.Where(c => c.idVendedor == obj).ToList();
                venta.NombreVendedor = contexto.Where(c => c.idVendedor == obj).Select(n => n.NombreVendedor).FirstOrDefault();
                foreach (var monto in VentasVendedor)
                {
                    venta.MontoTotal += monto.MontoVendedor;
                }

                modelo.ListaVentas.Add(venta);
            }

            return modelo;

        }
    }
}
