﻿using System;
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
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalBackend.View
{
    /// <summary>
    /// Lógica de interacción para ProductoView.xaml
    /// </summary>
    public partial class ProductoView :  MetroWindow
    {
        public ProductoView()
        {
            InitializeComponent();
            this.DataContext = new ProductoViewModel(this);            
        }
        public ProductoView(InventarioView instancia)
        {
            InitializeComponent();
            this.DataContext = new ProductoViewModel(this, instancia);
        }
    }
}
