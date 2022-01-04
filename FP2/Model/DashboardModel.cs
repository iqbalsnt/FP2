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

        public DashboardModel()
        {
            template = new ModelTemplate();
        }

        public DataSet totalPelanggan()
        {
            string query = ("SELECT COUNT(*) FROM Pelanggan");
            return template.SelectData(query, "Pelanggan");
        }
    }
}
