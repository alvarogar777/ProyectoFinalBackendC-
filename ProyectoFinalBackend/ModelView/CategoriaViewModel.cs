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
    public class CategoriaViewModel : INotifyPropertyChanged, ICommand
    {
        private CategoriaViewModel _Instancia;
        private ObservableCollection<Categoria> _Categoria;
        private Boolean _IsReadOnlyDescripcion = false;
        CategoriaModel categoriaModel = new CategoriaModel();

        private string _Descripcion;


        public CategoriaViewModel()
        {
            this.Instancia = this;
        }

        public ObservableCollection<Categoria> Categorias
        {
            get
            {
                this._Categoria = categoriaModel.ShowList;
                return this._Categoria;
            }
            set { this._Categoria = value; }
        }


        public CategoriaViewModel Instancia
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
                result = await categoriaModel.Add();
                if (result == true)
                {
                    this.IsReadOnlyDescripcion = false;
                
                }
            }
            if (parameter.Equals("Save"))
            {
                var metroWindow = (Application.Current.MainWindow as MetroWindow);
                this.Descripcion = "";
                if (this.Descripcion.Equals("")){
                    await metroWindow.ShowMessageAsync("Error", "Ingrese Una categoria");
                }
                else
                {
                    await metroWindow.ShowMessageAsync("Exito", "Categoria ingresada exitosamente");
                    this.Categorias.Add(categoriaModel.Save(this.Descripcion));
                    this.Descripcion = "";
                    this.IsReadOnlyDescripcion = true;
                }                  

            }
        }




    }
}
