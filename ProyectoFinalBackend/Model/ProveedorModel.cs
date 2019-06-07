using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Data.Entity;

namespace ProyectoFinalBackend.Model
{
    public class ProveedorModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Proveedor> _Proveedor;

        public ObservableCollection<Proveedor> ShowList
        {
            get
            {
                if (this._Proveedor == null)
                {
                    this._Proveedor = new ObservableCollection<Proveedor>();
                    foreach (Proveedor elemento in db.Proveedores.ToList())
                    {
                        this._Proveedor.Add(elemento);
                    }
                }
                return this._Proveedor;
            }
            set { this._Proveedor = value; }

        }

        public async Task<bool> Add(ProveedorView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nuevo proveedor",
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

        public Proveedor Save(string nit, string razon_Social, string direccion, string paginaWeb, string contactoPrincipal)
        {
            Proveedor nuevo = new Proveedor();
            nuevo.Nit = nit;
            nuevo.Razon_Social = razon_Social;
            nuevo.Direccion = direccion;
            nuevo.Pagina_Web = paginaWeb;
            nuevo.ContactoPrincipal = contactoPrincipal;
            db.Proveedores.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Proveedor selectProveedor)
        {
            db.Proveedores.Remove(selectProveedor);
            db.SaveChanges();
        }

        public dynamic update(int CodigoProveedor, string nit, string razon_Social, string direccion, string paginaWeb, string contactoPrincipal)
        {
            var updatProveedor = this.db.Proveedores.Find(CodigoProveedor);
            updatProveedor.Nit= nit;
            updatProveedor.Razon_Social = razon_Social;
            updatProveedor.Direccion = direccion;
            updatProveedor.Pagina_Web = paginaWeb;
            updatProveedor.ContactoPrincipal = contactoPrincipal;
            this.db.Entry(updatProveedor).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatProveedor;
        }
    }
}
