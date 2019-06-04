using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.Entity;
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
    public class TipoEmpaqueModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<TipoEmpaque> _TipoEmpaque;

        public ObservableCollection<TipoEmpaque> ShowList
        {
            get
            {
                if (this._TipoEmpaque == null)
                {
                    this._TipoEmpaque = new ObservableCollection<TipoEmpaque>();
                    foreach (TipoEmpaque elemento in db.TipoEmpaques.ToList())
                    {
                        this._TipoEmpaque.Add(elemento);
                    }
                }
                return this._TipoEmpaque;
            }
            set { this._TipoEmpaque = value; }

        }

        public async Task<bool> Add()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            var resultado = await metroWindow.ShowMessageAsync("Agregando", "Desea Agregar un nuevo Empaque",
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

        public TipoEmpaque Save(string descripcion)
        {
            TipoEmpaque nuevo = new TipoEmpaque();
            nuevo.Descripcion = descripcion;
            db.TipoEmpaques.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(TipoEmpaque selectTipoEmpaque)
        {
            db.TipoEmpaques.Remove(selectTipoEmpaque);
            db.SaveChanges();
        }

        public dynamic update(int CodigoEmpaque, string descripcion)
        {
            var updatTipoEmpaque = this.db.TipoEmpaques.Find(CodigoEmpaque);
            updatTipoEmpaque.Descripcion = descripcion;
            this.db.Entry(updatTipoEmpaque).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatTipoEmpaque;
        }
    }
}
