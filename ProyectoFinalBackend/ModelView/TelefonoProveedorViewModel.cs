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
    public class TelefonoProveedorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TelefonoProveedor> _TelefonoProveedor;

        public ObservableCollection<TelefonoProveedor> TelefonoProveedores
        {
            get { return this._TelefonoProveedor; }
            set { this._TelefonoProveedor = value; }
        }
        public TelefonoProveedorViewModel()
        {
            this.CodigoTelefono = 11111;
        }

        public int CodigoTelefono { get; set; }
        public String Numero { get; set; }
        public String Descripcion { get; set; }
        public int CodigoProveedor { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
