using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Model
{
    class PaketPelanggan
    {
        ModelTemplate template;

        public string No_Pelanggan { get; set; }
        public string No_Produk { get; set; }
        public string No_PaketPelanggan { get; set; }

        public PaketPelanggan()
        {
            template = new ModelTemplate();
        }

        public DataSet PaketPelangganShow(string cari)
        {
            DataSet ds = new DataSet();
            if(cari == null)
            {
                ds = template.Select("Paket_Pelanggan", null);
            }
            else
            {
                string kondisi = "No_Pelanggan LIKE '%" + No_Pelanggan + "%' OR No_Produk LIKE '%" + No_Produk + "%'";
                ds = template.Select("Paket_Pelanggan", kondisi);
            }
            return ds;
        }

        public bool insertPaketPelanggan()
        {
            string data = "'" + No_Pelanggan + "','" + No_Produk + "'";
            return template.Insert("Paket_Pelanggan", data);
        }

        public bool deletePaketPelanggan()
        {
            string data = "No_PaketPelanggan = '" + No_PaketPelanggan + "'";
            return template.Delete("Paket_Pelanggan", data);
        }
    }
}
