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

        public DataSet showPembayaran(string cari)
        {
            DataSet set = new DataSet();
            if (cari == null)
            {
                set = template.Select("Pembayaran", null);
            }
            else
            {
                string kondisi = "No_Pembayaran LIKE '%" + cari + "%' OR No_PaketPelanggan LIKE '%" + cari + "%' OR Bulan_Bayar LIKE '%" + cari + "%'";
                set = template.Select("Pembayaran", kondisi);
            }
            return set;
        }

        public bool insertPembayaran()
        {
            string data = "'" + No_PaketPelanggan + "','" + Bulan_Bayar + "'";
            return template.Insert("Pembayaran", data);
        }
    }
}
