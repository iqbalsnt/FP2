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

        //instance
        public Pelanggan(View.DataPelanggan DataPelanggan)
        {
            PelangganModel = new Model.PelangganModel();
            this.DataPelanggan = DataPelanggan;
        }

        //show data pelanggan di datagrid (View)
        public void dataPelanggan()
        {
            string cari = DataPelanggan.txtCari.Text;
            DataSet data = PelangganModel.SelectPelanggan(cari);
            DataPelanggan.DgPelanggan.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
