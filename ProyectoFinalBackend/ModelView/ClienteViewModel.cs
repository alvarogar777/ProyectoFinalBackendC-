using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoFinalBackend.ModelView
{
    public class ClienteViewModel : INotifyPropertyChanged
    {
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
