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
    /// Interaction logic for Pembayaran.xaml
    /// </summary>
    public partial class Pembayaran : Window
    {
        private Controller.Pembayaran pembayaran;
        public Pembayaran()
        {
            InitializeComponent();
            pembayaran = new Controller.Pembayaran(this);
            pembayaran.DataPembayaran();
        }

        
        private void BtnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindows dashboardWindows = new DashboardWindows();
            dashboardWindows.Show();
            Close();
        }

        private void BtnSimpan_Click(object sender, RoutedEventArgs e)
        {
            pembayaran.insertPembayaran();
        }
    }
}
