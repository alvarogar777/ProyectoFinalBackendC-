using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoFinalBackend.ModelView
{
    public class RoleViewModel : INotifyPropertyChanged
    {
        public RoleViewModel()
        {
            this.ID = 11111;
        }
        public int ID { get; set; }
        public String Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
