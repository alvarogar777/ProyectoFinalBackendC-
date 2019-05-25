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
    public class CompraViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Compra> _Compra;

        public ObservableCollection<Compra> Compras
        {
            get { return this._Compra; }
            set { this._Compra = value; }

        }

        public CompraViewModel()
        {
            this.IdCompra = 22;
        }

        public int IdCompra { get; set; }
        public int NumeroDocumento { get; set; }
        public int CodigoProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
