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
    public class EmailProveedorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<EmailProveedor> _EmailProveedor;

        public ObservableCollection<EmailProveedor> EmailProveedores
        {
            get { return this._EmailProveedor; }
            set { this._EmailProveedor = value; }
        }

        public EmailProveedorViewModel()
        {
            this.CodigoEmail = 22;
        }

        public int CodigoEmail { get; set; }
        public String Email { get; set; }
        public int CodigoProveedor { get; set; }
   
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
