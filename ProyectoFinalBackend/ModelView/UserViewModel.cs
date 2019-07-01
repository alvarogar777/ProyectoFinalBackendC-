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
    public class UserViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _User;

        public ObservableCollection<User> Users
        {
            get { return this._User; }
            set { this._User = value; }
        }
        public UserViewModel()
        {
            this.ID = 333333;
        }
        public int ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Boolean Enabled { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
