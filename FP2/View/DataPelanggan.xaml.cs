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
    /// Interaction logic for DataPelanggan.xaml
    /// </summary>
    public partial class DataPelanggan : Window
    {
        //deklarasi objek controller
        private Controller.Pelanggan Pelanggan;
        public DataPelanggan()
        {
            InitializeComponent();

            //instance
            Pelanggan = new Controller.Pelanggan(this);

            //function utk menampilkan data di datagrd
            Pelanggan.dataPelanggan();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            TambahPelanggan tambahPelanggan = new TambahPelanggan();
            tambahPelanggan.Show();
            Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void txtCari_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pelanggan.dataPelanggan();
        }
    }
}
