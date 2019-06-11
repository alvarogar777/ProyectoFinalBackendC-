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
                    //var query = (from p in db.Productos.ToList()
                    //             where p.Descripcion == ""
                    //             orderby p.Descripcion
                    //             select new Producto
                    //             {
                    //                 Descripcion = p.Descripcion
                    //             }
                    //             ).ToList();

                    //var query2 = db.Productos.Select(p => new { p.Descripcion, p.Categoria }).ToList();
                    foreach (Producto elemento in db.Productos.ToList())
                    {
                       this._Producto.Add(elemento);
                    }
                }
                return this._Producto;
            }
            set { this._Producto = value; }

        }

        public async Task<bool> Add(ProductoView mensaje)
        {
            var resultado = await mensaje.ShowMessageAsync("Agregando", "Desea Agregar una nuevo Producto",
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

        public Producto Save(int codigoCategoria,int codigoEmpaque, string descripcion, 
            decimal precioUnitario, decimal precioPorDocena, decimal precioPorMayor, int existencia, string imagen, string nombreImagen)
        {
            Producto nuevo = new Producto();
            nuevo.CodigoCategoria = codigoCategoria;
            nuevo.CodigoEmpaque = codigoEmpaque;
            nuevo.Descripcion = descripcion;
            nuevo.PrecioUnitario = precioUnitario;
            nuevo.PrecioPorDocena = precioPorDocena;
            nuevo.PrecioPorMayor = precioPorMayor;
            nuevo.Existencia = existencia;
            nuevo.Imagen = imagen;
            nuevo.NombreImagen = nombreImagen;
            db.Productos.Add(nuevo);
            db.SaveChanges();
            return nuevo;
        }

        public void Delete(Producto selectProducto)
        {
            db.Productos.Remove(selectProducto);
            db.SaveChanges();
        }

        public dynamic update(int codigoProducto,int codigoCategoria, int codigoEmpaque, string descripcion,
            decimal precioUnitario, decimal precioPorDocena, decimal precioPorMayor, int existencia, string imagen, string nombreImagen)
        {
            var updatProducto = this.db.Productos.Find(codigoProducto);
            updatProducto.CodigoCategoria = codigoCategoria;
            updatProducto.CodigoEmpaque = codigoEmpaque;
            updatProducto.Descripcion = descripcion;
            updatProducto.PrecioUnitario = precioUnitario;
            updatProducto.PrecioPorDocena = precioPorDocena;
            updatProducto.PrecioPorMayor = precioPorMayor;
            updatProducto.Existencia = existencia;
            updatProducto.Imagen = imagen;
            updatProducto.NombreImagen = nombreImagen;

            this.db.Entry(updatProducto).State = EntityState.Modified;
            this.db.SaveChanges();
            return updatProducto;
        }
    }
}
