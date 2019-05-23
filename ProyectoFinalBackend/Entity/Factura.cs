using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class Factura
    {
        public int Numerofactura { get; set; }
        public String Nit { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
