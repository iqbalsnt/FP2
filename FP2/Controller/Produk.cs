using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace FP2.Controller
{
    class Produk
    {
        private Model.ProdukModel produkModel;
        private View.Paket produkView;
        private View.TambahProduk tambahProduk;
        private View.UpdateProduk upProduk;

        public Produk(View.Paket produkView)
        {
            produkModel = new Model.ProdukModel();
            this.produkView = produkView;
        }
        public Produk(View.TambahProduk tambahProduk)
        {
            produkModel = new Model.ProdukModel();
            this.tambahProduk = tambahProduk;
        }

        public Produk(View.UpdateProduk upProduk)
        {
            produkModel = new Model.ProdukModel();
            this.upProduk = upProduk;
        }

        public void dataProduk()
        {
            string cari = produkView.txtCari.Text;
            DataSet data = produkModel.DataProduk(cari);
            produkView.DgProduk.ItemsSource = data.Tables[0].DefaultView;
        }

        public void insertProduk()
        {
            produkModel.Nama_Produk = tambahProduk.txtNamaProduk.Text;
            produkModel.Harga = tambahProduk.txtHarga.Text;
            bool result = produkModel.insertProduk();
            if(result)
            {
                MessageBox.Show("Berhasil Menambahkan Produk");
                View.Paket paket = new View.Paket();
                paket.Show();
                tambahProduk.Close();
                
            }
            {
                //MessageBox.Show("Gagal Menambahkan Produk");
            }
        }

        public void deleteProduk()
        {
            produkModel.No_Produk = View.Paket.No_Produk;
            bool result = produkModel.deleteProduk();
            if( result )
            {
                MessageBox.Show("Data Produk Berhasil Dihapus");
            }
            else
            {
                MessageBox.Show("Data Produk Gagal Dihapus");
            }
        }

        public void updateProduk()
        {
            produkModel.No_Produk = upProduk.txtIdProduk.Text;
            produkModel.Nama_Produk = upProduk.txtNamaProduk.Text;
            produkModel.Harga = upProduk.txtHarga.Text;

            bool result = produkModel.updateProduk();
            if(result)
            {
                MessageBox.Show("Data Produk Berhasil Diubah");
                View.Paket paket = new View.Paket();
                View.UpdateProduk update = new View.UpdateProduk();
                paket.Show();
                update.Close();
            }
            else
            {
                MessageBox.Show("Gagal Mengubah Data Produk");
            }

        }
    }
}
