using ProyectoFinalBackend.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoFinalBackend.ModelView
{
    public class MainViewModel : INotifyPropertyChanged, ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        //private MainWindow main;
        public MainViewModel Instancia { get; set; }
        public MainViewModel()
        {
            this.Instancia = this;
            //this.Main = main;
        }

        //public MainWindow Main
        //{
        //    get
        //    {
        //        return this.main;
        //    }
        //    set
        //    {
        //        this.main = value;
        //    }
        //}


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //Main.Hide();
            if (parameter.Equals("TipoEmpaque"))
            {
                new TipoEmpaqueView().ShowDialog();
            }
            else if (parameter.Equals("Categoria"))
            {
                new CategoriaView().ShowDialog();
            }
            else if (parameter.Equals("Inventario"))
            {
                new InventarioView().ShowDialog();
            }
            else if (parameter.Equals("Producto"))
            {
                new ProductoView().ShowDialog();
            }
            else if (parameter.Equals("GenerarVenta"))
            {
                new GenerarVentaView().ShowDialog();
            }
            else if (parameter.Equals("EmailProveedor"))
            {
                new EmailProveedorView().ShowDialog();
            }
            else if (parameter.Equals("Proveedor"))
            {
                new ProveedorView().ShowDialog();
            }
            else if (parameter.Equals("TelefonoProveedor"))
            {
                new TelefonoProveedorView().ShowDialog();
            }
            else if (parameter.Equals("GenerarCompra"))
            {
                new GenerarCompraView().ShowDialog();
            }
            else if (parameter.Equals("Clientes"))
            {
                new ClienteView().ShowDialog();
            }
            else if (parameter.Equals("EmailClientes"))
            {
                new EmailClienteView().ShowDialog();
            }
            else if (parameter.Equals("TelefonoClientes"))
            {
                new TelefonoClienteView().ShowDialog();
            }
            else if (parameter.Equals("Compra"))
            {
                new CompraView().ShowDialog();
            }
            else if (parameter.Equals("Factura"))
            {
                new FacturaView().ShowDialog();
            }
            
        }
    }
}