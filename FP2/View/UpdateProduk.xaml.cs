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
    /// Interaction logic for UpdateProduk.xaml
    /// </summary>
    
    public partial class UpdateProduk : Window
    {
        Controller.Produk produk;

        public static string No_Produk;
        public static string Nama_Produk;
        public static string Harga;
        public UpdateProduk()
        {
            InitializeComponent();
            produk = new Controller.Produk(this);
            txtNamaProduk.Text = Nama_Produk;
            txtHarga.Text = Harga;
        }

        private void BtnUbah_Click(object sender, RoutedEventArgs e)
        {
            produk.updateProduk(); 
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Paket paket = new Paket();
            paket.Show();
            Close();
        }
    }
}
