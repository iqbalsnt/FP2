using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Model
{
    class PembayaranModel
    {
        ModelTemplate template;

        public string No_PaketPelanggan { get; set; }
        public string Bulan_Bayar { get; set; }

        public PembayaranModel()
        {
            template = new ModelTemplate();
        }

        //Select % Search
        public DataSet SelectPembayaran(string cari)
        {
            DataSet dp = new DataSet();
            if (cari == "")
            {
                dp = template.Select("Pembayaran", null);
            }
            else
            {
                string kondisi = "No_PaketPelanggan LIKE '%" + cari + "%' OR Bulan_Bayar LIKE '%" + cari + "%'";
                dp = template.Select("Pelanggan", kondisi);
            }
            return dp;
        }
    }
}
