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
    public class DetalleCompraModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<DetalleCompra> _DetalleCompra;

        public ObservableCollection<DetalleCompra> ShowList
        {
            get
            {
                if (this._DetalleCompra == null)
                {
                    this._DetalleCompra = new ObservableCollection<DetalleCompra>();
                    foreach (DetalleCompra elemento in db.DetalleCompras.ToList())
                    {
                        this._DetalleCompra.Add(elemento);
                    }
                }
                return this._DetalleCompra;
            }
            set { this._DetalleCompra = value; }

        }

        public async Task<bool> Add(GenerarCompraView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar un nuevo detalle compra",
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

        public DetalleCompra Save(int idCompra,int codigoProducto,int cantidad, decimal precio,decimal subtotal)
        {
            DetalleCompra nuevo = new DetalleCompra();
            nuevo.IdCompra = idCompra;
            nuevo.CodigoProducto = codigoProducto;
            nuevo.Cantidad = cantidad;
            nuevo.Precio = precio;
            nuevo.SubTotal = subtotal;
            db.DetalleCompras.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(DetalleCompra selectDetalleCompra)
        {
            db.DetalleCompras.Remove(selectDetalleCompra);
            db.SaveChanges();
        }

        public dynamic update(int idDetalle, int idCompra, int codigoProducto, int cantidad, decimal precio)
        {
            var updatDetalleCompra = this.db.DetalleCompras.Find(idDetalle);
            updatDetalleCompra.IdCompra= idCompra;
            updatDetalleCompra.CodigoProducto = codigoProducto;
            updatDetalleCompra.Cantidad = cantidad;
            updatDetalleCompra.Precio = precio;

            this.db.Entry(updatDetalleCompra).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatDetalleCompra;
        }

        public List<DetalleCompra> FindList(int idCompra)
        {
            //List<DetalleFactura> query = (from p in db.DetalleFacturas.ToList()
            //                              where p.NumeroFactura == numeroFactura
            //                              orderby p.CodigoDetalle
            //                              select new DetalleFactura
            //                              {

            //                              }
            //             ).ToList();
            List<DetalleCompra> resultado = this.db.DetalleCompras.Where(p => p.IdCompra == idCompra).ToList();
            return resultado;
        }
    }


}
