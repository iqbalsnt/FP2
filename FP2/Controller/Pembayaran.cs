﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            
        }
    }
}
