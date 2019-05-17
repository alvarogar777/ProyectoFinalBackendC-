using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Model
{
    public class Proveedor
    {
        public int CodigoProveedor { get; set; }
        public String Nit { get; set; }
        public String Razon_Social { get; set; }
        public String Direccion { get; set; }
        public String Pagina_Web { get; set; }
        public String ContactoPrincipal { get; set; }
    }
}
