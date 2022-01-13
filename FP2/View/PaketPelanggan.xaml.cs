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
    /// Interaction logic for PaketPelanggan.xaml
    /// </summary>
    public partial class PaketPelanggan : Window
    {
        Controller.PaketPelanggan paketPelanggan;
        public static string No_PaketPelanggan;

        public void getdata()
        {
            object item = DgPaket.SelectedItem;
            No_PaketPelanggan = (DgPaket.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
        }

        public void setStaticVar()
        {
            No_PaketPelanggan = "";
        }
        public PaketPelanggan()
        {
            InitializeComponent();
            paketPelanggan = new Controller.PaketPelanggan(this);
            paketPelanggan.PaketPelangganShow();
        }

        private void BtnCari_Click(object sender, RoutedEventArgs e)
        {
            paketPelanggan.PaketPelangganShow();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            paketPelanggan.InsertPaketPelanggan();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            object item = DgPaket.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Silahkan Pilih Dulu");
            }
            else
            {
                getdata();
                if (MessageBox.Show("Yakin Ingin Hapus Data", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    paketPelanggan.DeletePaketPelanggan();
                }
                setStaticVar();
                paketPelanggan.PaketPelangganShow();
            }
        }
    }
}
