using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2.Controller
{
    class Pembayaran
    {
        //deklarasi objek utk view & model
        private Model.PembayaranModel PembayaranModel;
        private View.Pembayaran PembayaranView;

        //instance
        public Pembayaran(View.Pembayaran pembayaran)
        {
            PembayaranModel = new Model.PembayaranModel();
            this.PembayaranView = PembayaranView;
        }

    }
}
