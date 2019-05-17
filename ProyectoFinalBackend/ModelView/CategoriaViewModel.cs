using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoFinalBackend.ModelView
{
    public class CategoriaViewModel : INotifyPropertyChanged
    {
        public CategoriaViewModel() {
            this.Descripcion = "Camisas";
        }
        public String Descripcion { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
