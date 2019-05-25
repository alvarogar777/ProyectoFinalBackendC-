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
    public class InventarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Inventario> _Inventario;

        public ObservableCollection<Inventario> Inventarios
        {
            get { return this._Inventario; }
            set { this._Inventario = value; }
        }

        public InventarioViewModel()
        {
            this.CodigoInventario = 22;
        }

        public int CodigoInventario { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime Fecha { get; set; }
        public String TipoRegistro { get; set; }
        public decimal Precio { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
    }
}
