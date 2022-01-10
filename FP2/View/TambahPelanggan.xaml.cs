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

namespace FP2.View
{
    /// <summary>
    /// Interaction logic for TambahPelanggan.xaml
    /// </summary>
    public partial class TambahPelanggan : Window
    {
        Controller.TambahPelanggan controller;
        public TambahPelanggan()
        {
            InitializeComponent();
            controller = new Controller.TambahPelanggan(this);
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            controller.addPelanggan();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            DataPelanggan dataPelanggan = new DataPelanggan();
            dataPelanggan.Show();
            Close();
        }

        private void BtnTambah_Click_1(object sender, RoutedEventArgs e)
        {
            controller.addPelanggan();
        }
    }
}
