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
    public class ClienteViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Cliente> _Cliente;

        public ObservableCollection<Cliente> Clientes
        {
            get { return this._Cliente; }
            set { this._Cliente = value; }

        }

        public ClienteViewModel()
        {
            this.Nit = "b-2288";
        }
        public String Nit { get; set; }
        public String DPI { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
