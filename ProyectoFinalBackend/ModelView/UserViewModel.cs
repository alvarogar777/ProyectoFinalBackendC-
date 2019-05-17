using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoFinalBackend.ModelView
{
    public class UserViewModel : INotifyPropertyChanged
    {
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
