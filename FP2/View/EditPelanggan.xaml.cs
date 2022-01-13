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
    /// Interaction logic for EditPelanggan.xaml
    /// </summary>
    public partial class EditPelanggan : Window
    {
        private Controller.Pelanggan pelanggan;
        public EditPelanggan()
        {
            InitializeComponent();
            pelanggan = new Controller.Pelanggan(this);
        }
        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataPelanggan dataPelanggan = new DataPelanggan();
            dataPelanggan.Show();
            Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            DataPelanggan dataPelanggan = new DataPelanggan();
            dataPelanggan.Show();
            Close();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            pelanggan.UpdatePelanggan();
            Close();
        }
    }
}
