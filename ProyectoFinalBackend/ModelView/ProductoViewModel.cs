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

namespace ProyectoFinalBackend.ModelView
{
    public class ProductoViewModel :  INotifyPropertyChanged, ICommand
    {
        private ProductoViewModel _Instancia;
        private ObservableCollection<Producto> _Producto;
        private Boolean _IsReadOnlyDescripcion = true;
        ProductoModel productoModel = new ProductoModel();

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public int CodigoProducto { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoEmpaque { get; set; }
        public String Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioPorDocena { get; set; }
        public decimal PrecioPorMayor { get; set; }
        public int Existencia { get; set; }
        public String Imagen { get; set; }

        public ProductoViewModel()
        {
            this.Instancia = this;
            this.Descripcion = "";
        }

        public ObservableCollection<Producto> Productos
        {
            get {
                this.Productos = productoModel.ShowList; 
                return this._Producto; }
            set { this._Producto = value; }
        }

        public ProductoViewModel Instancia
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

        public Boolean IsReadOnlyDescripcion
        {
            get
            {
                return this._IsReadOnlyDescripcion;
            }
            set
            {
                this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion");
            }
        }



        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            bool result;
            if (parameter.Equals("Add"))
            {
                result = await productoModel.Add();
                if (result == true)
                {
                    ///this.IsReadOnlyDescripcion = false;

                }
            }
            if (parameter.Equals("Save"))
            {
                var metroWindow = (Application.Current.MainWindow as MetroWindow);


                if (this.Descripcion.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Una categoria");
                }
                else
                {
                    await metroWindow.ShowMessageAsync("Exito", "Categoria ingresada exitosamente");
                    this.Productos.Add(productoModel.Save(this.Descripcion));
                    this.Descripcion = "";
                   // this.IsReadOnlyDescripcion = true;
                }

            }
        }
    }
}
