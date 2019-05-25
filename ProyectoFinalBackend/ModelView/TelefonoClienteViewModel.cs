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
    public class TelefonoClienteViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TelefonoCliente> _TelefonoCliente;

        public ObservableCollection<TelefonoCliente> TelefonoClientes
        {
            get { return this._TelefonoCliente; }
            set { this._TelefonoCliente = value; }
        }
        public TelefonoClienteViewModel()
        {
            this.CodigoTelefono = 11111;
        }

        public int CodigoTelefono { get; set; }
        public String Numero { get; set; }
        public String Descripcion { get; set; }
        public String Nit { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
