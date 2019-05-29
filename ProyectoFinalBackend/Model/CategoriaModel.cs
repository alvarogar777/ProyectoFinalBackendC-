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
    public class CategoriaModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Categoria> _Categoria;

        public ObservableCollection<Categoria> ShowList
        {
            get
            {
                if (this._Categoria == null)
                {
                    this._Categoria = new ObservableCollection<Categoria>();
                    foreach (Categoria elemento in db.Categorias.ToList())
                    {
                        this._Categoria.Add(elemento);
                    }
                }
                return this._Categoria;
            }
            set { this._Categoria = value; }

        }

        public async Task<bool> Add()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            var resultado = await metroWindow.ShowMessageAsync("Agregando", "Desea Agregar una nueva categoria",
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

        public Categoria Save(string descripcion)
        {
            Categoria nuevo = new Categoria();
            nuevo.Descripcion = descripcion;
            db.Categorias.Add(nuevo);
            db.SaveChanges();
            return nuevo;        
        }

    }
}
