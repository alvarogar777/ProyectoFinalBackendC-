using MahApps.Metro.Controls;
using ProyectoFinalBackend.ModelView;
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

namespace ProyectoFinalBackend.View
{
    /// <summary>
    /// Lógica de interacción para GenerarVentaView.xaml
    /// </summary>
    public partial class GenerarVentaView : MetroWindow
    {
        public GenerarVentaView()
        {
            InitializeComponent();
            this.DataContext = new GenerarVentaViewModel(this);

        }
    }
}
