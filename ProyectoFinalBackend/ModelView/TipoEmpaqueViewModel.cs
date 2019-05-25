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
    public class TipoEmpaqueViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TipoEmpaque> _TipoEmpaque;

        public ObservableCollection<TipoEmpaque> TipoEmpaques
        {
            get { return this._TipoEmpaque; }
            set { this._TipoEmpaque = value; }
        }

        public TipoEmpaqueViewModel()
        {
            this.CodigoEmpaque = 2222;
        }
        public int CodigoEmpaque { get; set; }
        public String Descripcion { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
