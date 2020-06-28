using BLL.LoginBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        DangNhapBLL _dangNhapBLL;
        main main;
        public Login()
        {
            InitializeComponent();
            _dangNhapBLL = new DangNhapBLL();
            main = new main();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(_dangNhapBLL.checkBLL(txtuser.Text.ToString(), txtmk.Text.ToString()) == 0)
            {
                MessageBox.Show("Thông tin không để trống", "Thông báo");
            }
            else if(_dangNhapBLL.checkBLL(txtuser.Text.ToString(), txtmk.Text.ToString()) == 2){
                MessageBox.Show("Thông tin tài khoản không đúng", "Thông báo");
            }
            else
            {
                main.Show();
                this.Hide();
            }
        }
    }
}
