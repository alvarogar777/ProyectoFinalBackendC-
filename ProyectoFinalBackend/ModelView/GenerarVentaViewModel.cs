using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;
using System.Windows.Input;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.View;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Data;

namespace ProyectoFinalBackend.ModelView
{
    public class GenerarVentaViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private GenerarVentaViewModel _Instancia;
        private ObservableCollection<GenerarVenta> _GenerarVenta;
        private ObservableCollection<Producto> _Producto;
        ProductoModel producto = new ProductoModel();
        DetalleFacturaModel detalleFactura = new DetalleFacturaModel();
        FacturaModel factura = new FacturaModel();
        ProductoModel productoUpdate = new ProductoModel();
        private GenerarVenta _SelectGenerarVenta;
        private Producto _SelectProducto;
        private GenerarVentaView _mensajes;
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
        List<GenerarVenta> nuevoGenerarVenta = new List<GenerarVenta>();
        #endregion

        #region Constructores
        public GenerarVentaViewModel(GenerarVentaView generarVentaView)
        {
            this.Instancia = this;
            BorrarCampos();
            Mensajes = generarVentaView;
        }


        #endregion

        #region Objeto Obbservador
        public ObservableCollection<GenerarVenta> GenerarVentas
        {
            get
            {
                if (this._GenerarVenta == null)
                {
                    this._GenerarVenta = new ObservableCollection<GenerarVenta>();
                    foreach (GenerarVenta elemento in nuevoGenerarVenta.ToList())
                    {
                        this._GenerarVenta.Add(elemento);
                    }
                }
                return this._GenerarVenta;
            }
            set { this._GenerarVenta = value; }
        }
        public ObservableCollection<Producto> Productos
        {
            get
            { 
                this._Producto = producto.ShowList;
                return this._Producto;
            }
            set {
                if (this._Producto == null)
                {
                    _Producto = value;

                }
                ChangeNotify("Productos");
            }
        }
        #endregion

        #region Geters and Seters
        public GenerarVentaViewModel Instancia
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

        public GenerarVentaView Mensajes
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
        
    
        public GenerarVenta SelectGenerarVenta
        {
            get { return this._SelectGenerarVenta; }
            set
            {
                if (value != null)
                {
                    this._SelectGenerarVenta = value;
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
                this._Cantidad= value;
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

        #endregion

        #region Metodos Enabled y validacion de campos


        public void BorrarCampos()
        {
            this.Nit= "";
            this.Total = "0";
            this.CantidadProducto = "";
            this.PrecioUnitario = "";
            this.PrecioPorDocena = "";
            this.PrecioPorMayor = "";
            this.Existencia = "";
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
        public  void Add()
        {
            GenerarVenta nuevo = new GenerarVenta();
            decimal totalTemporal=0;
            if (this.SelectProducto != null && !this.CantidadProducto.Equals(""))
            {
                if (Convert.ToInt16(this.CantidadProducto)<=Convert.ToInt16(this.Existencia))
                {
                    try
                    {
                        if (Convert.ToInt16(this.CantidadProducto) <= 11) { nuevo.PrecioUnitario = Convert.ToDecimal(this.PrecioUnitario); }
                        else if (Convert.ToInt16(this.CantidadProducto) <= 15) { nuevo.PrecioUnitario = Convert.ToDecimal(this.PrecioPorDocena); }
                        else if (Convert.ToInt16(this.CantidadProducto) > 15) { nuevo.PrecioUnitario = Convert.ToDecimal(this.PrecioPorMayor); }
                        nuevo.CodigoProducto = this.SelectProducto.CodigoProducto;
                        nuevo.Descripcion = this.SelectProducto.Descripcion;
                        nuevo.Cantidad = Convert.ToInt16(this.CantidadProducto);
                        nuevo.Total = (Convert.ToInt16(this.CantidadProducto) * nuevo.PrecioUnitario);
                        this.GenerarVentas.Add(nuevo);

                        foreach (GenerarVenta row in GenerarVentas.ToList())
                        {
                            totalTemporal = totalTemporal + Convert.ToDecimal(row.Total);
                        }
                        this.Total = totalTemporal.ToString();
                    }
                    catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }
                }
            }
            else
            {
                Mensajes.ShowMessageAsync("Error", "Debe seleccionar alguna fila e ingresar una cantidad");
            }
            
            this.CantidadProducto = ""; 
        }

        public async void Save()
        {
            bool isEmpty = GenerarVentas.Any();
            if (isEmpty && !Mensajes.Nit.Text.ToString().Equals("") )
            {
                try
                {
                    var resultado = await Mensajes.ShowMessageAsync("Agregando", "Desea generar una nueva factura",
                    MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
                    {
                        AffirmativeButtonText = "Si",
                        NegativeButtonText = "No",
                        AnimateShow = true,
                        AnimateHide = false
                    });
                    if (resultado == MessageDialogResult.Affirmative)
                    {
                        Factura ultimoRegistro = factura.Save(Mensajes.Nit.Text.ToString(), DateTime.Today, Convert.ToDecimal(this.Total));
                        foreach (GenerarVenta row in GenerarVentas.ToList())
                        {
                            detalleFactura.Save(ultimoRegistro.Numerofactura, row.CodigoProducto, row.Cantidad, row.PrecioUnitario, 0);
                            this.GenerarVentas.Remove(row);
                            productoUpdate.updateExistencia(row.CodigoProducto,row.Cantidad);                           
                        }
                        foreach (Producto row in Productos.ToList())
                        {                        
                            this.Productos.Remove(row);                            
                        }


                        //CollectionViewSource.GetDefaultView(this.Productos).Refresh();

                        ProductoModel actualizado = new ProductoModel();
                        this.Total = "0";
                        this.Nit = "";
                        this.PrecioPorDocena = "";
                        this.PrecioPorMayor = "";
                        this.PrecioUnitario = "";
                        this.Cantidad ="";
                        this.Existencia = "";
                        await Mensajes.ShowMessageAsync("Exito", "Factura Ingresada correctamente");
                        foreach (Producto row in actualizado.ShowList2())
                        {
                            this.Productos.Add(row);
                        }
                    }
                    else
                    {
                        await Mensajes.ShowMessageAsync("Error", "No se ingreso ninguna factura");
                    }
                }
                catch (Exception e)
                {
                    await Mensajes.ShowMessageAsync("Error", e.Message);
                }                
            }
            else
            {
              await Mensajes.ShowMessageAsync("Error", "Debe de haber registros para facturar y elegir un cliente");
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
                        foreach (GenerarVenta row in GenerarVentas.ToList())
                        {
                           this.GenerarVentas.Remove(row);
                        }
                    this.Total = "0";
                    this.Nit = "";

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
            if (this.SelectGenerarVenta != null)
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
                        this.GenerarVentas.Remove(this.SelectGenerarVenta); 
                        foreach (GenerarVenta row in GenerarVentas.ToList())
                        {
                            totalTemporal = totalTemporal + Convert.ToDecimal(row.Total); 
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
                new ClienteView(Mensajes).ShowDialog();
            }

        }
        #endregion
    }
}
