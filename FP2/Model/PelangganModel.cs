using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Model
{
    class PelangganModel
    {
        //create object
        ModelTemplate template;

        //deklarasi var sesui field tabel pelanggan
        public string No_Pelanggan { get; set; }
        public string Nama { get; set; }
        public string No_HP { get; set; }
        public string Tgl_Registrasi { get; set; }
        public string Alamat { get; set; }
        public PelangganModel()
        {
            template = new ModelTemplate();
        }

        //Select % Search
        public DataSet SelectPelanggan(string cari)
        {
            DataSet dp = new DataSet();
            if(cari == "")
            {
                dp = template.Select("Pelanggan", null);
            }else
            {
                string kondisi = "No_Pelanggan LIKE '%"+cari+"%' OR Nama LIKE '%"+cari+"%' OR No_HP LIKE '%"+cari+"%' OR Tgl_Registrasi LIKE '%"+cari+"%' OR Alamat LIKE '%"+cari+"%' OR";
                dp = template.Select("Pelanggan", kondisi);
            }
            return dp;
        }

        //delete pelanggan model
        public bool deletePelanggan()
        {
            string data = ("No_Pelanggan = '" + No_Pelanggan + "'");
            return template.Delete("Pelanggan", data);
        }
    }
}
