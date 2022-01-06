using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FP2.Model
{
    class DashboardModel
    {
        ModelTemplate template;

        public static string totPelanggan;
        public DashboardModel()
        {
            template = new ModelTemplate();
        }
        
        public DataSet totalPelanggan()
        {
            DataSet ds = new DataSet();
            totPelanggan = ds.Tables[0].Rows[0][0].ToString();
            return ds;
        }
    }
}
