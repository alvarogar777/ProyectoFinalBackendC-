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
    public class CategoriaViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Categoria> _Categoria;

        public ObservableCollection<Categoria> Categorias
        {
            get { return this._Categoria; }
            set { this._Categoria = value; }

        }

        public CategoriaViewModel() {
            this.Descripcion = "Camisas";
        }
        public String Descripcion { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
