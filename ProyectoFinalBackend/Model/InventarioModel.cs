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
    public class InventarioModel
    {
        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private ObservableCollection<Inventario> _Inventario;
        public string Descripcion { get; set; }
        public ObservableCollection<Inventario> ShowList
        {
            get
            {
                if (this._Inventario == null)
                {
                    this._Inventario = new ObservableCollection<Inventario>();
                    //var query = (from p in db.Productos.ToList()
                    //             where p.Descripcion == ""
                    //             orderby p.Descripcion
                    //             select new Producto
                    //             {
                    //                 Descripcion = p.Descripcion
                    //             }
                    //             ).ToList();

                    //var query2 = db.Productos.Select(p => new { p.Descripcion, p.Categoria }).ToList();
                    foreach (Inventario elemento in db.Inventarios.ToList())
                    {
                        this._Inventario.Add(elemento);
                    }
                }
                return this._Inventario;
            }
            set { this._Inventario = value; }

        }

        public async Task<bool> Add(InventarioView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nuevo Inventario",
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

        public Inventario Save(int codigoProducto, string tipoRegistro, decimal precio, int entradas, int salidas)
        {
            Inventario nuevo = new Inventario();
            nuevo.Fecha = DateTime.Now;
            nuevo.CodigoProducto = codigoProducto;
            nuevo.TipoRegistro = tipoRegistro;
            nuevo.Precio = precio;
            nuevo.Entradas = entradas;
            nuevo.Salidas = salidas;
            db.Inventarios.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Inventario selectInventario)
        {
            db.Inventarios.Remove(selectInventario);
            db.SaveChanges();
        }

        public dynamic update(int codigoInventario, int codigoProducto, string tipoRegistro, decimal precio, int entradas, int salidas)
        {
            var updatInventario = this.db.Inventarios.Find(codigoInventario);
            updatInventario.CodigoProducto= codigoProducto;
            updatInventario.TipoRegistro = tipoRegistro;
            updatInventario.Precio = precio;
            updatInventario.Entradas = entradas;
            updatInventario.Salidas = salidas;
            this.db.Entry(updatInventario).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatInventario;
        }
    }
}
