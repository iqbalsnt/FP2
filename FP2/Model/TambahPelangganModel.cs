using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace FP2.Model
{
    class TambahPelangganModel
    {
        //create object
        ModelTemplate template;

        //deklarasi var sesui field tabel pelanggan
        public string Nama { get; set; }
        public string No_HP { get; set; }
        public string Tgl_Registrasi { get; set; }
        public string Alamat { get; set; }
        public TambahPelangganModel()
        {
            template = new ModelTemplate();
        }

        //insert data pelanggan
        public bool insertPelanggan()
        {
                string data = "'"+Nama+"','"+No_HP+"','"+Tgl_Registrasi+"','"+Alamat+"'";
            return template.Insert("Pelanggan", data);
        }
        

    }
}
