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

namespace FP2.View
{
    /// <summary>
    /// Interaction logic for DashboardWindows.xaml
    /// </summary>
    public partial class DashboardWindows : Window
    {
        public DashboardWindows()
        {
            InitializeComponent();
        }

        private void DataPelanggan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataPelanggan datapelanggan = new DataPelanggan();
            datapelanggan.Show();
            Close();
        }
    }
}
