using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoFinalBackend.ModelView
{
    public class TipoEmpaqueViewModel : INotifyPropertyChanged
    {
        public TipoEmpaqueViewModel()
        {
            this.CodigoEmpaque = 2222;
        }
        public int CodigoEmpaque { get; set; }
        public String Descripcion { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
