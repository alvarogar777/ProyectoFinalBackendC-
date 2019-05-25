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
    public class DetalleCompraModelView : INotifyPropertyChanged
    {
        private ObservableCollection<DetalleCompra> _DetalleCompra;

        public ObservableCollection<DetalleCompra> DetalleCompras
        {
            get { return this._DetalleCompra; }
            set { this._DetalleCompra = value; }
        }

        public DetalleCompraModelView()
        {
            this.IdDetalle = 22;
        }

        public int IdDetalle { get; set; }
        public int IdCompra { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

    }

    
}
