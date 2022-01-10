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
    /// Interaction logic for DashboardWindows.xaml
    /// </summary>
    public partial class DashboardWindows : Window
    {
        private Controller.Dashboard dashboard;
        public DashboardWindows()
        {
            InitializeComponent();
            //dashboard = new Controller.Dashboard();
            //dashboard.TotalPelanggan();
        }
        private void LblDataPelanggan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataPelanggan dataPelanggan = new DataPelanggan();
            dataPelanggan.Show();
            Close();
        }

        private void LblProduk_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void LblPembayaran_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Show();
            Close();
        }

        private void LblPengaturan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PengaturanAkun pengaturanAkun = new PengaturanAkun();
            pengaturanAkun.Show();
            Close();
        }
    }
}
