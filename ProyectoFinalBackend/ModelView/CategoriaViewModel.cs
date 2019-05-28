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

        private ControlAlmacenDataContext db = new ControlAlmacenDataContext();
        private CategoriaViewModel _Instancia;
        private ObservableCollection<Categoria> _Categoria;
        private Boolean _IsReadOnlyDescripcion = true;

        private string _Descripcion;
        

        public CategoriaViewModel()
        {
            
            this.Instancia = this;
        }


        public ObservableCollection<Categoria> Categorias
        {
            get
            {
                if (this._Categoria == null)
                {
                    this._Categoria = new ObservableCollection<Categoria>();
                    foreach (Categoria elemento in db.Categorias.ToList())
                    {
                        this._Categoria.Add(elemento);
                    }
                }

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
                ChangeNotify("Name");
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
            if (parameter.Equals("Add"))
            {
           
                var metroWindow = (Application.Current.MainWindow as MetroWindow);
                var resultado= await metroWindow.ShowMessageAsync("Agregando", "Desea Agregar una nueva categoria",MessageDialogStyle.AffirmativeAndNegative
                    , new MetroDialogSettings
                    {
                        AffirmativeButtonText = "Si",
                        NegativeButtonText = "No",
                        AnimateShow = true,
                        AnimateHide = false
                    });
                if (resultado == MessageDialogResult.Affirmative)
                {
                    await metroWindow.ShowMessageAsync("Exito", "Agregado exitosamente");

                    this.IsReadOnlyDescripcion = false;
                }
                


            }


        }




    }
}
