using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class EmailProveedor
    {
        public int CodigoEmail { get; set; }
        public String Email { get; set; }
        public int CodigoProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
