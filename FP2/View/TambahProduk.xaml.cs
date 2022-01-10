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
    /// Interaction logic for TambahProduk.xaml
    /// </summary>
    public partial class TambahProduk : Window
    {
        private Controller.Produk Produk;
        public TambahProduk()
        {
            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, RoutedEventArgs e)
        {
            Produk.insertProduk();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Paket paket = new Paket();
            paket.Show();
            Close();
        }

        private void BtnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Paket paket = new Paket();
            paket.Show();
            Close();
        }
    }
}
