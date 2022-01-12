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
            DataSet ds = new DataSet();
            ds = temp.Select("Akun", "Username = '" + id + "' AND Pass = '" + password + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                result = true;
                namaUser = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool updateUser()
        {
            string data = "Username = '" + id + "', Pass = '" + password + "'";
            string kondisi = "Username = '" + id + "'";
            return temp.Update("Akun", data, kondisi);
        }
    }
}
