using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2.Controller
{

    class Dashboard
    {
        //deklarasi objek utk view & model
        private Model.DashboardModel DashboardModel;
        private View.DashboardWindows dashboardView;

        public Dashboard()
        {
            DashboardModel = new Model.DashboardModel();
            dashboardView = new View.DashboardWindows();
        }

       // public void TotalPelanggan()
       // {
         //   dashboardView dashboard = new View.DashboardWindows();
            

        //}
    }
}
