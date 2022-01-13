using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace FP2.Controller
{
    class Pelanggan
    {
        //deklarasi objek utk view & model
        private Model.PelangganModel PelangganModel;
        private View.DataPelanggan DataPelanggan;
        private View.updatePelanggan updatePelanggan;

        //instance
        public Pelanggan(View.DataPelanggan DataPelanggan)
        {
            PelangganModel = new Model.PelangganModel();
            this.DataPelanggan = DataPelanggan;
        }

        public Pelanggan(View.updatePelanggan updatePelanggan)
        {
            PelangganModel = new Model.PelangganModel();
            this.updatePelanggan = updatePelanggan;
        }

        //show data pelanggan di datagrid (View)
        public void dataPelanggan()
        {
            string cari = DataPelanggan.txtCari.Text;
            DataSet data = PelangganModel.SelectPelanggan(cari);
            DataPelanggan.DgPelanggan.ItemsSource = data.Tables[0].DefaultView;
        }

        public void Delete()
        {
            PelangganModel.No_Pelanggan = View.DataPelanggan.No_Pelanggan;
            bool result = PelangganModel.deletePelanggan();
            if(result)
            {
                MessageBox.Show("Data Pelanggan Berhasil Dihapus");
            }
            else
            {
                MessageBox.Show("Data Pelanggan Gagal Berhasil Dihapus");
            }
        }

        
    }
}
