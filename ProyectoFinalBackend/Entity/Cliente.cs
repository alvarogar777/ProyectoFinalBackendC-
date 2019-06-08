using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class Cliente
    {
        public String Nit { get; set; }
        public String Dpi { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Emailcliente> Emailcliente { get; set; }
        public virtual ICollection<TelefonoCliente> TelefonoClientes { get; set; }
    }
}
