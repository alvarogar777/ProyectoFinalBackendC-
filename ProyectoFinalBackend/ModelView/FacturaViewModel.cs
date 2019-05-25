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
    public class FacturaViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Factura> _Factura;

        public ObservableCollection<Factura> Facturas
        {
            get { return this._Factura; }
            set { this._Factura = value; }
        }

        public FacturaViewModel()
        {
            this.Numerofactura = 22;
        }

        public int Numerofactura { get; set; }
        public String Nit { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

    }
}
