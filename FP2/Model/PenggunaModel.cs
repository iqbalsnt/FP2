using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace FP2.Model
{
    class PenggunaModel
    {
        ModelTemplate temp;

        public string id { get; set; }
        public string password { get; set; }

        //cache
        public static string namaUser;

        public PenggunaModel()
        {
            temp = new ModelTemplate();
        }

        public Boolean CekLogin()
        {
            bool result;
            
            if (id == "adham" && password == "shultan")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
