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

namespace ProyectoFinalBackend.Model
{
    public class CompraModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Compra> _Compra;

        public ObservableCollection<Compra> ShowList
        {
            get
            {
                if (this._Compra == null)
                {
                    this._Compra = new ObservableCollection<Compra>();
                    foreach (Compra elemento in db.Compras.ToList())
                    {
                        this._Compra.Add(elemento);
                    }
                }
                return this._Compra;
            }
            set { this._Compra = value; }

        }

        public async Task<bool> Add(GenerarCompraView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nueva compra",
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

        public Compra Save(int numeroDocumento, int codigoProveedor, DateTime fecha, decimal total)
        {
            Compra nuevo = new Compra();
            nuevo.NumeroDocumento = numeroDocumento;
            nuevo.CodigoProveedor = codigoProveedor;
            nuevo.Fecha = fecha;
            nuevo.Total = total;
            db.Compras.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Compra selectCompra)
        {
            db.Compras.Remove(selectCompra);
            db.SaveChanges();
        }

        public dynamic update(int idCompra, int numeroDocumento, int codigoProveedor, DateTime fecha, decimal total)
        {
            var updateCompra = this.db.Compras.Find(idCompra);
            updateCompra.NumeroDocumento = numeroDocumento;
            updateCompra.CodigoProveedor = codigoProveedor;
            updateCompra.Fecha = fecha;
            updateCompra.Total = total;

            this.db.Entry(updateCompra).State = EntityState.Modified;
            this.db.SaveChanges();
            return updateCompra;
        }

        public Compra FindOne(int idCompra)
        {
            Compra resultado = this.db.Compras.Single(s => s.IdCompra == idCompra);
            return resultado;
        }
    }
}
