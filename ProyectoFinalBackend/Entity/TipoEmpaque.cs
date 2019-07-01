using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class TipoEmpaque
    {
        public int CodigoEmpaque { get; set; }
        public String Descripcion { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
