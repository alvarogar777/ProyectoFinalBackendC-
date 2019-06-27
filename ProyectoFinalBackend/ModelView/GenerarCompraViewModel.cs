using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;
using ProyectoFinalBackend.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoFinalBackend.ModelView
{
    public class GenerarCompraViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private GenerarCompraViewModel _Instancia;
        private ObservableCollection<DetalleCompra> _GenerarCompra;
        private ObservableCollection<Producto> _Producto;
        ProductoModel producto = new ProductoModel();
        DetalleCompraModel detalleCompra = new DetalleCompraModel();
        CompraModel compra = new CompraModel();
        ProductoModel productoUpdate = new ProductoModel();
        private DetalleCompra _SelectGenerarCompra;
        private Producto _SelectProducto;
        private GenerarCompraView _mensajes;
        private string _Nit;
        private string _Total;
        private string _UrlImagen;
        private string _Imagen;
        private string _Cantidad;
        private string _CantidadProducto;
        private string _PrecioUnitario;
        private string _PrecioPorDocena;
        private string _PrecioPorMayor;
        private string _Existencia;
        private string _Precio;
        private string _NumeroDocumento;
        List<DetalleCompra> nuevoGenerarVenta = new List<DetalleCompra>();
        #endregion

        #region Constructores
        public GenerarCompraViewModel(GenerarCompraView generarCompraView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = generarCompraView;
        }


        #endregion

        #region Objeto Obbservador
        public ObservableCollection<DetalleCompra> GenerarCompras
        {
            get
            {
                if (this._GenerarCompra == null)
                {
                    this._GenerarCompra = new ObservableCollection<DetalleCompra>();
                    foreach (DetalleCompra elemento in nuevoGenerarVenta.ToList())
                    {
                        this._GenerarCompra.Add(elemento);
                    }

                }
                return this._GenerarCompra;
            }
            set { this._GenerarCompra = value; }
        }
        public ObservableCollection<Producto> Productos
        {
            get
            {
                this._Producto = producto.ShowList;

                return this._Producto;
            }
            set
            {
                if (this._Producto == null)
                {
                    _Producto = value;

                }
                ChangeNotify("Productos");
            }
        }
        #endregion

        #region Geters and Seters
        public GenerarCompraViewModel Instancia
        {
            get
            {
                return this._Instancia;
            }
            set
            {
                this._Instancia = value;
            }
        }

        public GenerarCompraView Mensajes
        {
            get
            {
                return this._mensajes;
            }
            set
            {
                this._mensajes = value;
            }
        }


        public DetalleCompra SelectGenerarCompra
        {
            get { return this._SelectGenerarCompra; }
            set
            {
                if (value != null)
                {
                    this._SelectGenerarCompra = value;
                    ChangeNotify("SelectGenerarVenta");
                }
            }
        }

        public Producto SelectProducto
        {
            get { return this._SelectProducto; }
            set
            {
                if (value != null)
                {
                    this._SelectProducto = value;
                    this.UrlImagen = @value.Imagen;
                    this.PrecioUnitario = value.PrecioUnitario.ToString();
                    this.PrecioPorDocena = value.PrecioPorDocena.ToString();
                    this.PrecioPorMayor = value.PrecioPorMayor.ToString();
                    this.Existencia = value.Existencia.ToString();
                    ChangeNotify("SelectProducto");
                }
            }
        }
        #endregion

        #region campos de la BD
        public string Nit
        {
            get
            {
                return _Nit;
            }
            set
            {
                this._Nit = value;
                ChangeNotify("Nit");
            }
        }
        public string Total
        {
            get
            {
                return _Total;
            }
            set
            {
                this._Total = value;
                ChangeNotify("Total");
            }
        }
        public string UrlImagen
        {
            get
            {
                return _UrlImagen;
            }
            set
            {
                this._UrlImagen = value;
                ChangeNotify("UrlImagen");
            }
        }
        public string Imagen
        {
            get
            {
                return _Imagen;
            }
            set
            {
                this._Imagen = value;
                ChangeNotify("Imagen");
            }
        }

        public string Cantidad
        {
            get
            {
                return _Cantidad;
            }
            set
            {
                this._Cantidad = value;
                ChangeNotify("Cantidad");
            }
        }

        public string CantidadProducto
        {
            get
            {
                return _CantidadProducto;
            }
            set
            {
                this._CantidadProducto = value;
                ChangeNotify("CantidadProducto");
            }
        }

        public string PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }
            set
            {
                this._PrecioUnitario = value;
                ChangeNotify("PrecioUnitario");
            }
        }

        public string PrecioPorDocena
        {
            get
            {
                return _PrecioPorDocena;
            }
            set
            {
                this._PrecioPorDocena = value;
                ChangeNotify("PrecioPorDocena");
            }
        }
        public string PrecioPorMayor
        {
            get
            {
                return _PrecioPorMayor;
            }
            set
            {
                this._PrecioPorMayor = value;
                ChangeNotify("PrecioPorMayor");
            }
        }

        public string Existencia
        {
            get
            {
                return _Existencia;
            }
            set
            {
                this._Existencia = value;
                ChangeNotify("Existencia");
            }
        }

        public string Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                this._Precio = value;
                ChangeNotify("Precio");
            }
        }


        public string NumeroDocumento
        {
            get { return _NumeroDocumento; }
            set {
                _NumeroDocumento = value;
                ChangeNotify("NumeroDocumento");
            }
        }

        #endregion

        #region Metodos Enabled y validacion de campos


        public void borrarCampos()
        {
            this.Nit = "";
            this.Total = "0";
            this.CantidadProducto = "";
            this.Existencia = "";
            this.NumeroDocumento = "";
            //this.GenerarVentas.IndexOf(null);
        }

        public bool ValidacionCampos()
        {
            bool resultado = true;
            if (Mensajes.Nit.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Nit");
                resultado = false;
            }
            else if (Mensajes.Total.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Total");
                resultado = false;
            }

            return resultado;
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public void Add()
        {
            DetalleCompra nuevo = new DetalleCompra();
            decimal totalTemporal = 0;
            if (this.SelectProducto != null )
            {
                    try
                    {
                        nuevo.Cantidad = Convert.ToInt16(this.Cantidad);
                        nuevo.Precio = Convert.ToDecimal(this.Precio);
                        nuevo.CodigoProducto = this.SelectProducto.CodigoProducto;
                        nuevo.SubTotal = nuevo.Precio * nuevo.Cantidad;
                        this.GenerarCompras.Add(nuevo);


                        foreach (DetalleCompra row in GenerarCompras.ToList())
                        {
                            totalTemporal = totalTemporal + Convert.ToDecimal(row.SubTotal);
                        }

                        this.Total = totalTemporal.ToString();
                        this.Precio = "";
                        this.Cantidad = "";
                    }
                    catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }
                
            }
            else
            {
                Mensajes.ShowMessageAsync("Error", "Debe seleccionar alguna fila e ingresar una cantidad");
            }

            this.CantidadProducto = "";
        }

        public async void Save()
        {
            bool isEmpty = GenerarCompras.Any();
                if (isEmpty && !Mensajes.Nit.Text.ToString().Equals("")&& !this.NumeroDocumento.Equals(""))
                {
                    try
                    {
                        Convert.ToInt16(this.NumeroDocumento);
                        var resultado = await Mensajes.ShowMessageAsync("Agregando", "Desea agregar una nueva compra",
                        MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
                        {
                            AffirmativeButtonText = "Si",
                            NegativeButtonText = "No",
                            AnimateShow = true,
                            AnimateHide = false
                        });
                        if (resultado == MessageDialogResult.Affirmative)
                        {
                            Compra ultimoRegistro = compra.Save(Convert.ToInt16(this.NumeroDocumento),Convert.ToInt16(Mensajes.Nit.Text.ToString()), DateTime.Today, Convert.ToDecimal(this.Total));
                            foreach (DetalleCompra row in GenerarCompras.ToList())
                            {
                                detalleCompra.Save(ultimoRegistro.IdCompra, row.CodigoProducto, row.Cantidad, row.Precio,row.SubTotal);
                                this.GenerarCompras.Remove(row);
                                productoUpdate.updateIncrementoExistencia(row.CodigoProducto, row.Cantidad);
                            }
                            foreach (Producto row in Productos.ToList())
                            {
                                this.Productos.Remove(row);
                            }
                        
                            //CollectionViewSource.GetDefaultView(this.Productos).Refresh();
                            ProductoModel actualizado = new ProductoModel();
                            this.Total = "0";
                            this.Nit = "";
                            this.NumeroDocumento = "";
                            this.Existencia = "";
                            await Mensajes.ShowMessageAsync("Exito", "Compra Ingresada correctamente");
                            foreach (Producto row in actualizado.ShowList2())
                            {
                                this.Productos.Add(row);
                            }
                        }
                        else
                        {
                            await Mensajes.ShowMessageAsync("Error", "No se ingreso ninguna compra");
                        }
                    }
                    catch (Exception e)
                    {
                        await Mensajes.ShowMessageAsync("Numero Documento debe ser de tipo numero entero", e.Message);
                    }
                }
                else
                {
                    await Mensajes.ShowMessageAsync("Error", "Debe de haber registros para la compra y elegir un proveedor");
                }
                         

        }

        public async void Cancel()
        {
            var respuesta = await Mensajes.ShowMessageAsync("Esta seguro de eliminar la factura", "Eliminar",
            MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
            {
                AffirmativeButtonText = "Si",
                NegativeButtonText = "No",
                AnimateShow = true,
                AnimateHide = false
            });

            if (respuesta == MessageDialogResult.Affirmative)
            {
                try
                {
                    foreach (DetalleCompra row in GenerarCompras.ToList())
                    {
                        this.GenerarCompras.Remove(row);
                    }
                    this.Total = "0";
                    this.Nit = "";
                    this.NumeroDocumento = "";

                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show(e.Message);
                }

                await Mensajes.ShowMessageAsync("Exito", "Factura eliminada Correctamente");
            }

            else
            {
                await Mensajes.ShowMessageAsync("Eliminar", "No se elimino ningun registro");

            }
        }

        public async void Delete()
        {
            decimal totalTemporal = 0;
            if (this.SelectGenerarCompra != null)
            {
                var respuesta = await Mensajes.ShowMessageAsync("Esta seguro de eliminar el registro", "Eliminar",
                MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
                {
                    AffirmativeButtonText = "Si",
                    NegativeButtonText = "No",
                    AnimateShow = true,
                    AnimateHide = false
                });

                if (respuesta == MessageDialogResult.Affirmative)
                {
                    try
                    {
                        this.GenerarCompras.Remove(this.SelectGenerarCompra);
                        foreach (DetalleCompra row in GenerarCompras.ToList())
                        {
                            totalTemporal = totalTemporal + Convert.ToDecimal(row.SubTotal);
                        }
                        this.Total = totalTemporal.ToString();

                    }
                    catch (Exception e)
                    {
                        System.Windows.MessageBox.Show(e.Message);
                    }

                    await Mensajes.ShowMessageAsync("Exito", "Registro eliminado Correctamente");
                }

                else
                {
                    await Mensajes.ShowMessageAsync("Eliminar", "No se elimino ningun registro");

                }
            }
            else
            {
            await Mensajes.ShowMessageAsync("Eliminar", "Debe seleccionar un registro");
            }
        }




        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.Equals("Add"))
            {
                Add();
                //Mensajes.DescripcionFocus.Focus();
            }
            if (parameter.Equals("Save"))
            {
                Save();
            }
            else if (parameter.Equals("Cancel"))
            {
                Cancel();
            }
            else if (parameter.Equals("Delete"))
            {
                Delete();
            }
            else if (parameter.Equals("AgregarCodigoCliente"))
            {
                new ProveedorView(Mensajes).ShowDialog();
            }

        }
        #endregion
    }
}
