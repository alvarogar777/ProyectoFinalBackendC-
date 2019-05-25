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
    public class RoleViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Role> _Role;

        public ObservableCollection<Role> Roles
        {
            get { return this._Role; }
            set { this._Role = value; }
        }
        public RoleViewModel()
        {
            this.ID = 11111;
        }
        public int ID { get; set; }
        public String Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
