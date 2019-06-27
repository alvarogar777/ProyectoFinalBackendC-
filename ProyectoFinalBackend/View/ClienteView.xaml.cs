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
using MahApps.Metro.Controls;
using ProyectoFinalBackend.ModelView;

namespace ProyectoFinalBackend.View
{
    /// <summary>
    /// Interaction logic for ClienteView.xaml
    /// </summary>
    public partial class ClienteView : MetroWindow
    {
        public ClienteView()
        {
            InitializeComponent();
            this.DataContext = new ClienteViewModel(this); 
        }
        public ClienteView(GenerarVentaView instancia)
        {
            InitializeComponent();
            this.DataContext = new ClienteViewModel(this,instancia);
        }

    }
}
