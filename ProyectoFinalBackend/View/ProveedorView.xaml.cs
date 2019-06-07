using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProyectoFinalBackend.ModelView;
using MahApps.Metro.Controls;

namespace ProyectoFinalBackend.View
{
    /// <summary>
    /// Interaction logic for ProveedorView.xaml
    /// </summary>
    public partial class ProveedorView : MetroWindow
    {
        public ProveedorView()
        {
            InitializeComponent();
            this.DataContext = new ProveedorViewModel(this);
        }
    }
}
