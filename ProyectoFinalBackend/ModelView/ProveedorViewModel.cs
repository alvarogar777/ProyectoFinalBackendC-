using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;

namespace ProyectoFinalBackend.ModelView
{
    public class ProveedorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Proveedor> _Proveedor;

        public ObservableCollection<Proveedor> Proveedores
        {
            get { return this._Proveedor; }
            set { this._Proveedor = value; }
        }
        public ProveedorViewModel()
        {
            this.CodigoProveedor = 15;
        }
        public int CodigoProveedor { get; set; }
        public String Nit { get; set; }
        public String Razon_Social { get; set; }
        public String Direccion { get; set; }
        public String Pagina_Web { get; set; }
        public String ContactoPrincipal { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
