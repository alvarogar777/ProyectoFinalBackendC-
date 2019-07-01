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
    public class FacturaModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Factura> _Factura;

        public ObservableCollection<Factura> ShowList
        {
            get
            {
                if (this._Factura == null)
                {
                    this._Factura = new ObservableCollection<Factura>();
                    foreach (Factura elemento in db.Facturas.ToList())
                    {
                        this._Factura.Add(elemento);
                    }
                }
                return this._Factura;
            }
            set { this._Factura = value; }

        }

        public async Task<bool> Add(GenerarVentaView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nueva factura",
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

        public Factura Save(string nit, DateTime fecha, decimal total)
        {
            Factura nuevo = new Factura();
            nuevo.Nit = nit;
            nuevo.Fecha = fecha;
            nuevo.Total = total;
            db.Facturas.Add(nuevo);            
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Factura selectFactura)
        {
            db.Facturas.Remove(selectFactura);
            db.SaveChanges();
        }

        public dynamic update(int Numerofactura, string nit, DateTime fecha, decimal total)
        {
            var updatFactura = this.db.Facturas.Find(Numerofactura);
            updatFactura.Nit = nit;
            updatFactura.Fecha = fecha;
            updatFactura.Total = total;

            this.db.Entry(updatFactura).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatFactura;
        }

        public Factura FindOne(int numeroFactura)
        {
            Factura resultado = this.db.Facturas.Single(s => s.Numerofactura == numeroFactura);            
            return resultado;
        }
    }
}
