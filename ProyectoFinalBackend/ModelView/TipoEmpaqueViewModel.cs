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
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace ProyectoFinalBackend.ModelView
{
    public class TipoEmpaqueViewModel : INotifyPropertyChanged,ICommand
    {
        private TipoEmpaqueViewModel _Instancia;
        private ObservableCollection<TipoEmpaque> _TipoEmpaque;
        private Boolean _IsReadOnlyDescripcion = true;
        TipoEmpaqueModel tipoEmpaque = new TipoEmpaqueModel();

        private string _Descripcion;


        public TipoEmpaqueViewModel()
        {
            this.Instancia = this;
            this.Descripcion = "";
        }

        public ObservableCollection<TipoEmpaque> TipoEmpaques
        {
            get
            {
                this._TipoEmpaque = tipoEmpaque.ShowList;
                return this._TipoEmpaque;
            }
            set { this._TipoEmpaque = value; }
        }


        public TipoEmpaqueViewModel Instancia
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

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                this._Descripcion = value;
                ChangeNotify("Descripcion");
            }
        }

        public Boolean IsReadOnlyDescripcion
        {
            get
            {
                return this._IsReadOnlyDescripcion;
            }
            set
            {
                this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion");
            }
        }

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

        public async void Execute(object parameter)
        {
            bool result;
            if (parameter.Equals("Add"))
            {
                result = await tipoEmpaque.Add();
                if (result == true)
                {
                    this.IsReadOnlyDescripcion = false;

                }
            }
            if (parameter.Equals("Save"))
            {
                var metroWindow = (Application.Current.MainWindow as MetroWindow);                
                
                if (this.Descripcion.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Una tipo de empaque");
                }
                else
                {
                    await metroWindow.ShowMessageAsync("Exito", "Tipo ingresado exitosamente");
                    this.TipoEmpaques.Add(tipoEmpaque.Save(this.Descripcion));
                    this.Descripcion = "";
                    this.IsReadOnlyDescripcion = true;
                }
            }
        }

    }
}
