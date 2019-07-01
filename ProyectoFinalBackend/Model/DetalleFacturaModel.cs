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
    public class DetalleFacturaModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<DetalleFactura> _DetalleFactura;

        public ObservableCollection<DetalleFactura> ShowList
        {
            get
            {
                if (this._DetalleFactura == null)
                {
                    this._DetalleFactura = new ObservableCollection<DetalleFactura>();
                    foreach (DetalleFactura elemento in db.DetalleFacturas.ToList())
                    {
                        this._DetalleFactura.Add(elemento);
                    }
                }
                return this._DetalleFactura;
            }
            set { this._DetalleFactura = value; }

        }

        public async Task<bool> Add(GenerarVentaView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar un nuevo detalle factura",
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

        public DetalleFactura Save(int numeroFactura, int codigoProducto, int cantidad, decimal precio,decimal descuento)
        {
            DetalleFactura nuevo = new DetalleFactura();
            nuevo.NumeroFactura = numeroFactura;
            nuevo.CodigoProducto = codigoProducto;
            nuevo.Cantidad = cantidad;
            nuevo.Precio = precio;
            nuevo.Descuento = descuento;
            db.DetalleFacturas.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(DetalleFactura selectFactura)
        {
            db.DetalleFacturas.Remove(selectFactura);
            db.SaveChanges();
        }

        public dynamic update(int CodigoDetalle, int numeroFactura, int codigoProducto, int cantidad, decimal precio, decimal descuento)
        {
            var updatDetalleFactura = this.db.DetalleFacturas.Find(CodigoDetalle);
            updatDetalleFactura.NumeroFactura = numeroFactura;
            updatDetalleFactura.CodigoProducto = codigoProducto;
            updatDetalleFactura.Cantidad = cantidad;
            updatDetalleFactura.Precio = precio;
            updatDetalleFactura.Descuento = descuento;
            this.db.Entry(updatDetalleFactura).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatDetalleFactura;
        }

        public List<DetalleFactura> FindList(int numeroFactura)
        {     
            //List<DetalleFactura> query = (from p in db.DetalleFacturas.ToList()
            //                              where p.NumeroFactura == numeroFactura
            //                              orderby p.CodigoDetalle
            //                              select new DetalleFactura
            //                              {

            //                              }
            //             ).ToList();
            List<DetalleFactura> resultado = this.db.DetalleFacturas.Where(p => p.NumeroFactura == numeroFactura).ToList();         
            return resultado;
        }
    }
}
