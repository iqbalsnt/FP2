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
        public static string No_Pelanggan;

        public void SetStaticVar()
        {
            No_Pelanggan = "";
        }

        public void getData()
        {
            object item = DgPelanggan.SelectedItem;
            No_Pelanggan = (DgPelanggan.SelectedCells[0].Column.GetCellContent(item)as TextBlock).Text;
        }
        public DataPelanggan()
        {
            InitializeComponent();

            //instance
            Pelanggan = new Controller.Pelanggan(this);

            //function utk menampilkan data di datagrd
            Pelanggan.dataPelanggan();
        }

        private void txtCari_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pelanggan.dataPelanggan();
        }

        private void BtnHapus_Click(object sender, RoutedEventArgs e)
        {
            object item = DgPelanggan.SelectedItem;
            if(item == null)
            {
                MessageBox.Show("Silahkan Pilih Dulu");
            }
            else
            {
                getData();
                if(MessageBox.Show("Yakin Ingin Hapus Data","Question",MessageBoxButton.YesNo,MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Pelanggan.Delete();
                }
                SetStaticVar();
                Pelanggan.dataPelanggan();
            }
        }

        private void BtnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnTambah_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TambahPelanggan tambahPelanggan = new TambahPelanggan();
            tambahPelanggan.Show();
            Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            TambahPelanggan tambahPelanggan = new TambahPelanggan();
            tambahPelanggan.Show();
            Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditPelanggan editPelanggan = new EditPelanggan();
            editPelanggan.Show();
            Close();
        }

        private void BtnCari_Click(object sender, RoutedEventArgs e)
        {
            Pelanggan.dataPelanggan();
        }
    }
}
