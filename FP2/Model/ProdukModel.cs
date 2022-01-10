using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool insertProduk()
        {
            string data = "'" + Nama_Produk + "','" + Harga + "'";
            return template.Insert("Produk", data);
        }
    }
}
