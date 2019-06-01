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
    public class ProductoModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Producto> _Producto;
        public string Descripcion { get; set; }
    

        public ObservableCollection<Producto> ShowList
        {
            get
            {
                if (this._Producto == null)
                {
                    this._Producto = new ObservableCollection<Producto>();
                    var query = (from p in db.Productos.ToList()
                                 where p.Descripcion == ""
                                 orderby p.Descripcion
                                 select new Producto
                                 {
                                     Descripcion = p.Descripcion
                                 }
                                 ).ToList();

                    //var query2 = db.Productos.Select(p => new { p.Descripcion, p.Categoria }).ToList();
                    foreach (Producto elemento in query)
                    {
                       this._Producto.Add(elemento);
                    }
                }
                return this._Producto;
            }
            set { this._Producto = value; }

        }

        public async Task<bool> Add()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            var resultado = await metroWindow.ShowMessageAsync("Agregando", "Desea Agregar una nuevo Producto",
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

        public Producto Save(string descripcion)
        {
            Producto nuevo = new Producto();
            nuevo.Descripcion = descripcion;
            db.Productos.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }
    }
}
