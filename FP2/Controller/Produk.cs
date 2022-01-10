using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Controller
{
    class Produk
    {
        private Model.ProdukModel produkModel;
        private View.Paket produkView;

        public Produk(View.Paket produkView)
        {
            produkModel = new Model.ProdukModel();
            this.produkView = produkView;
        }

        public void dataProduk()
        {
            string cari = produkView.txtCari.Text;
            DataSet data = produkModel.DataProduk(cari);
            produkView.DgProduk.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
