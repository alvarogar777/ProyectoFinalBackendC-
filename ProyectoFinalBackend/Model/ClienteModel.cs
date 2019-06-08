using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProyectoFinalBackend.Model
{
    public class ClienteModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Cliente> _Cliente;

        public ObservableCollection<Cliente> ShowList
        {
            get
            {
                if (this._Cliente == null)
                {
                    this._Cliente = new ObservableCollection<Cliente>();
                    foreach (Cliente elemento in db.Clientes.ToList())
                    {
                        this._Cliente.Add(elemento);
                    }
                }
                return this._Cliente;
            }
            set { this._Cliente = value; }

        }

        public async Task<bool> Add(ClienteView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nuevo cliente",
                MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
                {
                    AffirmativeButtonText = "Si",
                    NegativeButtonText = "No",
                    AnimateShow = true,
                    AnimateHide = false
                });
            if (resultado == MessageDialogResult.Affirmative)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Cliente Save(string nit, string dpi, string nombre, string direccion)
        {
            Cliente nuevo = new Cliente();
            nuevo.Nit = nit;
            nuevo.Dpi = dpi;
            nuevo.Nombre = nombre;
            nuevo.Direccion = direccion;
            db.Clientes.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Cliente selectCliente)
        {
            db.Clientes.Remove(selectCliente);
            db.SaveChanges();
        }

        public dynamic update(string nit, string dpi, string nombre, string direccion)
        {
            var updatCliente = this.db.Clientes.Find(nit);
            updatCliente.Dpi = dpi;
            updatCliente.Nombre = nombre;
            updatCliente.Direccion = direccion;
            this.db.Entry(updatCliente).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatCliente;
        }
    }
}
