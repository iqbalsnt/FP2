using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FP2.Controller
{
    class Pengguna
    {
        //declare object
        Model.PenggunaModel pengguna;
        private View.LoginWindow login;
        private View.PengaturanAkun akun;
        //instance
        public Pengguna(View.LoginWindow login)
        {
            pengguna = new Model.PenggunaModel();
            this.login = login;
        }

        public Pengguna(View.PengaturanAkun akun)
        {
            pengguna = new Model.PenggunaModel();
            this.akun = akun;
        }

        public void Login()
        {
            pengguna.id = login.txtUsername.Text;
            pengguna.password = login.txtPassword.Password;
            bool result = pengguna.CekLogin();
            if (result)
            {
                View.DashboardWindows windows = new View.DashboardWindows();
                windows.lblUser.Content = Model.PenggunaModel.namaUser;
                windows.Show();
                login.Close();
            }
            else
            {
                MessageBox.Show("Maaf, username/password anda salah!");
                login.txtUsername.Text = "";
                login.txtPassword.Password = "";
                login.txtUsername.Focus();
            }
        }

        public void updateuser()
        {
            pengguna.id = akun.txtUsername.Text;
            pengguna.password = akun.txtPassword.Text;
            bool result = pengguna.updateUser();
            if(result)
            {
                MessageBox.Show("Berhasil Update Akun");
                View.DashboardWindows windows = new View.DashboardWindows();
                windows.Show();
            }
            else
            {
                MessageBox.Show("Gagal Update Akun");
            }
            
        }
    }
}
