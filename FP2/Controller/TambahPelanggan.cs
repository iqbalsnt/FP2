using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace FP2.Controller
{
    class TambahPelanggan
    {
        //deklarasi objek utk view & model
        private Model.TambahPelangganModel TambahPelangganModel;
        private View.TambahPelanggan tambahPelanggan;

        public TambahPelanggan(View.TambahPelanggan tambahPelanggan)
        {
            TambahPelangganModel = new Model.TambahPelangganModel();
            this.tambahPelanggan = tambahPelanggan;
        }

        public void addPelanggan()
        {
            TambahPelangganModel.Nama = tambahPelanggan.txtNama.Text;
            TambahPelangganModel.No_HP = tambahPelanggan.txtHp.Text;
            TambahPelangganModel.Tgl_Registrasi = tambahPelanggan.DpRegis.Text;
            TambahPelangganModel.Alamat = tambahPelanggan.txtAlamat.Text;
            bool result = TambahPelangganModel.insertPelanggan();
            if (result)
            {
                MessageBox.Show("Penambahan Pelanggan Berhasil " +
                    "silahkan cek pada data pelanggan");
                View.DataPelanggan dataPelanggan = new View.DataPelanggan();
                dataPelanggan.Show();
                tambahPelanggan.Close();
            }
            else
            {
                MessageBox.Show("Penambahan Pelanggan Gagal");
            }
        }
    }
}
