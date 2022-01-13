using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace FP2.Controller
{
    class Pembayaran
    {
        private Model.PembayaranModel pembayaranModel;
        private View.Pembayaran pembayaranView;

        public Pembayaran(View.Pembayaran pembayaranView)
        {
            pembayaranModel = new Model.PembayaranModel();
            this.pembayaranView = pembayaranView;
        }

        public void DataPembayaran()
        {
            string cari = pembayaranView.txtCari.Text;
            DataSet data = pembayaranModel.showPembayaran(cari);
            pembayaranView.DgPembayaran.ItemsSource = data.Tables[0].DefaultView;
        }

        public void insertPembayaran()
        {
            pembayaranModel.No_PaketPelanggan = pembayaranView.txtID.Text;
            pembayaranModel.Bulan_Bayar = pembayaranView.cmbBulanBayar.SelectionBoxItem.ToString();
            bool result = pembayaranModel.insertPembayaran();
            if(result)
            {
                MessageBox.Show("Berhasil Menambahkan Pembayaran");
            }
            else
            {
                MessageBox.Show("Gagal Menambahkan Pembayaran");
            }
        }

        public void deletePembayaran()
        {
            pembayaranModel.No_Pembayaran = View.Pembayaran.No_Pembayaran;
            bool result = pembayaranModel.deletePembayaran();
            if(result)
            {
                MessageBox.Show("Berhasil Menghapus Data Pembayaran");
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Data Pembayaran");
            }
        }
    }
}
