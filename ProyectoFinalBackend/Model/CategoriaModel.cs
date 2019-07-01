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

        public async Task<bool> Add(CategoriaView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nueva categoria",
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

        public void Delete(Categoria selectCategoria)
        {
            db.Categorias.Remove(selectCategoria);
            db.SaveChanges();
        }

        public dynamic update(int CodigoCategoria, string descripcion)
        {
            var updatCategoria = this.db.Categorias.Find(CodigoCategoria);
            updatCategoria.Descripcion = descripcion;
            this.db.Entry(updatCategoria).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatCategoria;
        }

    }
}
