using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace FP2.Controller
{
    class PaketPelanggan
    {
        private Model.PaketPelanggan PaketPelangganmodel;
        private View.PaketPelanggan PaketPelangganview;

        public PaketPelanggan(View.PaketPelanggan PaketPelangganview)
        {
            PaketPelangganmodel = new Model.PaketPelanggan();
            this.PaketPelangganview = PaketPelangganview;
        }

        public void PaketPelangganShow()
        {
            string cari = PaketPelangganview.txtCari.Text;
            DataSet data = PaketPelangganmodel.PaketPelangganShow(cari);
            PaketPelangganview.DgPaket.ItemsSource = data.Tables[0].DefaultView;
        }

        public void InsertPaketPelanggan()
        {
            PaketPelangganmodel.No_Pelanggan = PaketPelangganview.txtIdPelanggan.Text;
            PaketPelangganmodel.No_Produk = PaketPelangganview.txtIdProduk.Text;
            bool result = PaketPelangganmodel.insertPaketPelanggan();
            if(result)
            {
                MessageBox.Show("Berhasil Menambahkan Paket Pelanggan");
            }
            else
            {
                MessageBox.Show("Gagal Menambahkan Paket Pelanggan");
            }
        }

        public void DeletePaketPelanggan()
        {
            PaketPelangganmodel.No_PaketPelanggan = View.PaketPelanggan.No_PaketPelanggan;
            bool result = PaketPelangganmodel.deletePaketPelanggan();
            if( result )
            {
                MessageBox.Show("Berhasil Hapus Paket Pelanggan");
            }
            else
            {
                MessageBox.Show("Gagal Hapus Paket Pelanggan");
            }
        }
    }
}
