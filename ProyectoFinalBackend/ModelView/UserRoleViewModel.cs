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
    public class UserRoleViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<UserRole> _UserRole;

        public ObservableCollection<UserRole> UserRoles
        {
            get { return this._UserRole; }
            set { this._UserRole = value; }
        }
        public UserRoleViewModel()
        {
            this.UserID = 333333;
        }
        public int UserID { get; set; }
        public int RoleID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
