using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Model
{
    class ProdukModel
    {
        ModelTemplate template;
        public string No_Produk { get; set; }
        public string Nama_Produk { get; set; }
        public string Harga { get; set; }

        public ProdukModel()
        {
            template = new ModelTemplate();
        }

        public DataSet DataProduk(string cari)
        {
            DataSet ds = new DataSet();
            if(cari == "")
            {
                ds = template.Select("Produk",null);
            }
            else
            {
                string kondisi = "No_Produk LIKE '%" + cari + "%' OR Nama_Produk LIKE '%" + cari + "%' OR Harga LIKE '%" + cari + "%'";
                ds = template.Select("Produk", kondisi);
            }
            return ds;
        }

        public bool insertProduk()
        {
            string data = "'" + Nama_Produk + "','" + Harga + "'";
            return template.Insert("Produk", data);
        }

        public bool deleteProduk()
        {
            string kondisi = ("No_Produk = '" + No_Produk + "'");
            return template.Delete("Produk", kondisi);
        }

        public bool updateProduk()
        {
            string data = "Nama_Produk = '" + Nama_Produk + "', Harga = '" + Harga + "'";
            string kondisi = "No_Produk = '" + No_Produk + "'";
            return template.Update("Produk",data,kondisi);
        }
    }
}
