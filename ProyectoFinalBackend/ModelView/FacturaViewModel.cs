using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;
using ProyectoFinalBackend.View;
using System.Windows.Input;
using MahApps.Metro.Controls.Dialogs;

namespace ProyectoFinalBackend.ModelView
{
    public class FacturaViewModel : INotifyPropertyChanged, ICommand
    {

        #region Campos
        private FacturaViewModel _Instancia;
        private ObservableCollection<Factura> _Factura;
        private ObservableCollection<DetalleFactura> _DetalleFactura;
        FacturaModel factura = new FacturaModel();
        DetalleFacturaModel detalleFactura = new DetalleFacturaModel();
        List<DetalleFactura> nuevoDetalle = new List<DetalleFactura>();
        private Factura _SelectFactura;
        private FacturaView _mensajes;
        private string _Total;
        List<DetalleFactura> nuevaDetalleFactura = new List<DetalleFactura>();
        #endregion

        #region Constructores
        public FacturaViewModel(FacturaView facturaView)
        {
            this.Instancia = this;
            Mensajes = facturaView;
         }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Factura> Facturas
        {
            get
            {
                this._Factura = factura.ShowList;
                return this._Factura;
            }
            set { this._Factura = value; }
        }

        public ObservableCollection<DetalleFactura> DetalleFacturas
        {
            get
            {
                if (this._DetalleFactura == null)
                {
                    this._DetalleFactura = new ObservableCollection<DetalleFactura>();
                    foreach (DetalleFactura elemento in nuevaDetalleFactura.ToList())
                    {
                        this._DetalleFactura.Add(elemento);
                    }
                }
                return this._DetalleFactura;
            }
            set { this._DetalleFactura = value; }
        }
        #endregion

        #region Geters and Seters
        public FacturaViewModel Instancia
        {
            get
            {
                return this._Instancia;
            }
            set
            {
                this._Instancia = value;
            }
        }

        public FacturaView Mensajes
        {
            get
            {
                return this._mensajes;
            }
            set
            {
                this._mensajes = value;
            }
        }

        public string Total
        {
            get
            {
                return _Total;
            }
            set
            {
                this._Total = value;
                ChangeNotify("Total");
            }
        }

        public Factura SelectFactura
        {
            get { return this._SelectFactura; }
            set
            {
                if (value != null)
                {
                    this._SelectFactura = value;

                    ChangeNotify("SelectCategoria");
                }
            }
        }
        #endregion

        #region Metodos Enabled y validacion de campos

        #endregion

        #region Metodos Add, Update, Delete, Save
        public void verDescripcion()
        {
            GenerarVenta nuevo = new GenerarVenta();
            decimal totalTemporal = 0;
            if (this.SelectFactura != null)
            {                
                try
                {
                    borrarDescripcion();
                    this.nuevoDetalle =detalleFactura.FindList(this.SelectFactura.Numerofactura);

                    foreach (DetalleFactura row in nuevoDetalle.ToList())
                    {
                        this.DetalleFacturas.Add(row);
                        totalTemporal = totalTemporal + (row.Cantidad * row.Precio);
                    }
                    this.Total = totalTemporal.ToString();
                   
                }
                catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }
            }
            else
            {
                Mensajes.ShowMessageAsync("Error", "Debe seleccionar alguna fila");
            }

        }

        public void borrarDescripcion()
        {
            foreach (DetalleFactura row in nuevoDetalle.ToList())
            {
                this.DetalleFacturas.Remove(row);
            }
        }

        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.Equals("VerDetalle"))
            {
                verDescripcion();
            }
            if (parameter.Equals("Save"))
            {
               
            }

        }
        #endregion

    }
}
