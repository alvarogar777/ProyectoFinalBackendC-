using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class Inventario
    {
        public int CodigoInventario { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime Fecha { get; set; }
        public String TipoRegistro { get; set; }
        public decimal Precio { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set;  }
        public virtual Producto Producto { get; set; }
    }
}
