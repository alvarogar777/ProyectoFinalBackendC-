using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;
using System.Windows.Input;
using ProyectoFinalBackend.View;
using MahApps.Metro.Controls.Dialogs;

namespace ProyectoFinalBackend.ModelView
{
    public class CompraViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private CompraViewModel _Instancia;
        private ObservableCollection<Compra> _Compra;
        private ObservableCollection<DetalleCompra> _DetalleCompra;
        CompraModel compra = new CompraModel();
        DetalleCompraModel detalleCompra = new DetalleCompraModel();
        List<DetalleCompra> nuevoDetalle = new List<DetalleCompra>();
        private Compra _SelectCompra;
        private CompraView _mensajes;
        private string _Total;
        List<DetalleCompra> nuevaCompraDetalle = new List<DetalleCompra>();
        #endregion

        #region Constructores
        public CompraViewModel(CompraView compraView)
        {
            this._Instancia = this;
            Mensajes = compraView;
        }
        #endregion

        #region Objeto Observador
        public ObservableCollection<Compra> Compras
        {
            get {
                this._Compra = compra.ShowList;
                return this._Compra; }
            set { this._Compra = value; }

        }

        public ObservableCollection<DetalleCompra> DetalleCompras
        {
            get {
                if (this._DetalleCompra == null)
                {
                    this._DetalleCompra = new ObservableCollection<DetalleCompra>();
                    foreach (DetalleCompra elemento in nuevaCompraDetalle.ToList())
                    {
                        this._DetalleCompra.Add(elemento);
                    }
                }
                return this._DetalleCompra;
            }
            set { this._DetalleCompra = value; }
        }
        #endregion

        #region Getters and Setters
        public CompraViewModel Instancia
        {
            get { return this._Instancia; }
            set { this._Instancia = value; }
        }

        public CompraView Mensajes
        {
            get { return this._mensajes; }
            set { this._mensajes = value; }
        }

        public string Total
        {
            get { return _Total; }
            set { this._Total = value;
                ChangeNotify("Total");
            }
        }

        public Compra SelectCompra
        {
            get { return _SelectCompra; }
            set
            {
                if (value != null)
                {
                    this._SelectCompra = value;
                    ChangeNotify("SelectCompra");
                }
            }
        }


        #endregion

        #region Metodos
        public void verDescripcion()
        {
            Compra nuevo = new Compra();
            decimal totalTemporal = 0;
            if (this.SelectCompra != null)
            {
                try
                {
                    borrarDescripcion();
                    this.nuevoDetalle = detalleCompra.FindList(this.SelectCompra.IdCompra);

                    foreach (DetalleCompra row in nuevoDetalle.ToList())
                    {
                        this.DetalleCompras.Add(row);
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
            foreach (DetalleCompra row in nuevoDetalle.ToList())
            {
                this.DetalleCompras.Remove(row);
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
            if (parameter.Equals("verDetalle"))
            {
                verDescripcion();
            }
        }

        #endregion
    }
}
