using ProyectoFinalBackend.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Model
{
    public class TelefonoClienteModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();

        public TelefonoCliente Save(string numero,string descripcion,string nit)
        {
            TelefonoCliente telefonoCliente = new TelefonoCliente();
            telefonoCliente.Numero = numero;
            telefonoCliente.Descripcion = descripcion;
            telefonoCliente.Nit = nit;
            db.TelefonoClientes.Add(telefonoCliente);
            db.SaveChanges();
            return telefonoCliente;
        }
        public List<TelefonoCliente> FindList(string nit)
        {
            List<TelefonoCliente> resultado = this.db.TelefonoClientes.Where(p => p.Nit == nit).ToList();
            return resultado;
        }

        public void Update(int codigoTelefono,string numero,string descripcion)
        {
            var updatTelefonoCliente = this.db.TelefonoClientes.Find(codigoTelefono);
            updatTelefonoCliente.Numero= numero;
            updatTelefonoCliente.Descripcion = descripcion;
            this.db.Entry(updatTelefonoCliente).State = EntityState.Modified;
            this.db.SaveChanges();
        }
        public void Delete(int codigoTelefono)
        {
            //context.Remove(context.Authors.Single(a => a.AuthorId == 1));
            db.TelefonoClientes.Remove(db.TelefonoClientes.Single(a => a.CodigoTelefono == codigoTelefono));
            db.SaveChanges();
        }
    }
}
