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

namespace ProyectoFinalBackend.ModelView
{
    public class GenerarVentaViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private GenerarVentaViewModel _Instancia;
        private ObservableCollection<GenerarVenta> _GenerarVenta;
        private ObservableCollection<Producto> _Producto;
        ProductoModel producto = new ProductoModel();
        private GenerarVenta _SelectGenerarVenta;
        private Producto _SelectProducto;
        private GenerarVentaView _mensajes;
        private bool _IsReadOnlyDescripcion = true;
        private string _Nit;
        private string _Total;
        private string _UrlImagen;
        private string _Imagen;
        private string _Cantidad;
        private string _CantidadProducto;
        List<GenerarVenta> nuevoGenerarVenta= new List<GenerarVenta>();



        #endregion

        #region Constructores
        public GenerarVentaViewModel(GenerarVentaView generarVentaView)
        {
            this.Instancia = this;
            borrarCampos();
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
            set { this._Producto = value; }
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


        #endregion

        #region Metodos Enabled y validacion de campos


        public void borrarCampos()
        {
            this.Nit= "";
            this.Total = "0";
            this.CantidadProducto = "";
            //this.GenerarVentas.IndexOf(null);
        }

        public bool validacionCampos()
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
        public  void add()
        {
            GenerarVenta nuevo = new GenerarVenta();
            decimal totalTemporal=0;
            if (this.SelectProducto != null && !this.CantidadProducto.Equals(""))
            {
                nuevo.CodigoProducto = this.SelectProducto.CodigoProducto;
                nuevo.Descripcion = this.SelectProducto.Descripcion;
                nuevo.Cantidad = Convert.ToInt16(this.CantidadProducto);
                nuevo.Total = (Convert.ToInt16(this.CantidadProducto) *this.SelectProducto.PrecioUnitario);
                this.GenerarVentas.Add(nuevo);

                foreach (GenerarVenta row in GenerarVentas.ToList())
                {
                    totalTemporal = totalTemporal + Convert.ToDecimal(row.Total);
                }
                this.Total = totalTemporal.ToString();
            }
            else
            {
                Mensajes.ShowMessageAsync("Error", "Debe seleccionar alguna fila e ingresar una cantidad");
            }
            
            this.CantidadProducto = ""; 
        }

        public async void save()
        {
 
        }

        public void update()
        {

        }

        public async void delete()
        {
            
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
                add();
                //Mensajes.DescripcionFocus.Focus();
            }
            if (parameter.Equals("Save"))
            {
                save();
            }
            else if (parameter.Equals("Update"))
            {
                update();
            }
            else if (parameter.Equals("Delete"))
            {
                delete();
            }

        }
        #endregion
    }
}
