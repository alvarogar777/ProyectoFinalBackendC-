using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public async Task<bool> Add()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            var resultado = await metroWindow.ShowMessageAsync("Agregando", "Desea Agregar una nuevo cliente",
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
            nuevo.DPI = dpi;
            nuevo.Nombre = nombre;
            nuevo.Direccion = direccion;
            db.Clientes.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }
    }
}
