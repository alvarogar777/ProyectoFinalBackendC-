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
    public class DetalleFacturaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DetalleFactura> _DetalleFactura;

        public ObservableCollection<DetalleFactura> DetalleFacturas
        {
            get { return this._DetalleFactura; }
            set { this._DetalleFactura = value; }
        }

        public DetalleFacturaViewModel()
        {
            this.CodigoDetalle = 22;
        }

        public int CodigoDetalle { get; set; }
        public int NumeroFactura { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
