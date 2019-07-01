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
    public class EmailClienteViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Emailcliente> _EmailCliente;

        public ObservableCollection<Emailcliente> EmailClientes
        {
            get { return this._EmailCliente; }
            set { this._EmailCliente = value; }
        }

        public EmailClienteViewModel()
        {
            this.CodigoEmail = 22;
        }

        public int CodigoEmail { get; set; }
        public String email { get; set; }
        public String Nit { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
