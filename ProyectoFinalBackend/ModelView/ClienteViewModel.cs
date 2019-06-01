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
    public class ClienteViewModel : INotifyPropertyChanged, ICommand
    {
        private ClienteViewModel _Instancia;
        private ObservableCollection<Cliente> _Cliente;
        private Boolean _IsReadOnlyNit = true;

        ClienteModel clienteModel = new ClienteModel();

        private string _Nit;
        private string _Dpi;
        private string _Nombre;
        private string _Direccion;

        public ClienteViewModel()
        {
            this.Instancia = this;
            this.Nit = "";
        }

        public ObservableCollection<Cliente> Clientes
        {
            get
            {
                this._Cliente = clienteModel.ShowList;
                return this._Cliente;
            }
            set { this._Cliente = value; }
        }


        public ClienteViewModel Instancia
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

        public string Nit
        {
            get
            {
                return _Nit;
            }
            set
            {
                this._Nit = value;
                ChangeNotify("Nit");
            }
        }

        public string Dpi
        {
            get
            {
                return _Dpi;
            }
            set
            {
                this._Dpi = value;
                ChangeNotify("Dpi");
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                this._Nombre = value;
                ChangeNotify("Nombre");
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                this._Direccion = value;
                ChangeNotify("Direccion");
            }
        }

        public Boolean IsReadOnlyNit
        {
            get
            {
                return this._IsReadOnlyNit;
            }
            set
            {
                this._IsReadOnlyNit = value;
                ChangeNotify("IsReadOnlyNit");
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
                result = await clienteModel.Add();
                if (result == true)
                {
                    this.IsReadOnlyNit = false;

                }
            }
            if (parameter.Equals("Save"))
            {
                var metroWindow = (Application.Current.MainWindow as MetroWindow);

                if (this.Nit.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Un Nit valido");
                }
                else if (this.Dpi.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Un Dpi valido");
                }
                else if(this.Nombre.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Un Nombre valido");
                }
                else if (this.Direccion.Equals(""))
                {
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Una Dirección valida");
                }
                else
                {                    
                    try
                    {
                        this.Clientes.Add(clienteModel.Save(this.Nit, this.Dpi, this.Nombre, this.Direccion));
                    }
                    catch (Exception e)
                    {
                        await metroWindow.ShowMessageAsync("Error", "Nit ya existente");
                    }
                    
                    this.Nit= "";
                    this.Dpi = "";
                    this.Nombre = "";
                    this.Direccion = "";
                    this.IsReadOnlyNit = true;
                }

            }
        }
    }
}
