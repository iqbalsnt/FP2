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
    /// Interaction logic for Paket.xaml
    /// </summary>
    public partial class Paket : Window
    {
        Controller.Produk Produk;
        public static string No_Produk;

        public void setStaticVar()
        {
            No_Produk = "";
        }
        public Paket()
        {
            InitializeComponent();
            Produk = new Controller.Produk(this);
            Produk.dataProduk();
        }

        public void getdata()
        {
            object item = DgProduk.SelectedItem;
            No_Produk = (DgProduk.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk();
            tambahProduk.Show();
            Close();
        }

        private void BtnHapus_Click(object sender, RoutedEventArgs e)
        {
            object item = DgProduk.SelectedItem;
            if(item == null)
            {
                MessageBox.Show("Silahkan Pilih Dulu");
            }
            else
            {
                getdata();
                if (MessageBox.Show("Yakin Ingin Hapus Data", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Produk.deleteProduk();
                }
                setStaticVar();
                Produk.dataProduk();
            }
        }

        private void DgProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = DgProduk.SelectedItem;
            UpdateProduk.No_Produk = (DgProduk.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //UpdateProduk.Nama_Produk = (DgProduk.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            //UpdateProduk.Harga = (DgProduk.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = DgProduk.SelectedItem;
            if(item == null)
            {
                MessageBox.Show("Silahkan Pilih Dulu");
            }
            else
            {
                getdata();
                setStaticVar();
                UpdateProduk updateProduk = new UpdateProduk();
                updateProduk.Show();
                Close();
            }
        }
    }
}
