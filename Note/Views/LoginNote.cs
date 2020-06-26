using Note.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note.Views
{
    public partial class LoginNote : Form
    {
        public LoginNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tendangnhap = this.txtlogin.Text.Trim();
            string matkhau = this.txtpass.Text.Trim();
            if (tendangnhap == "")
            {
                errorProvider1.SetError(this.txtlogin, "Hãy nhập tên đăng nhập");
                return;
            }
            else if (tendangnhap == "")
            {
                errorProvider1.SetError(this.txtpass, "Hãy nhập mật khẩu");
                return;
            }
            else if(!DangNhapController.kiemTraTenDangNhapDaTonTai(tendangnhap))
            {
                errorProvider1.SetError(this.txtlogin, "Tên đăng nhập không tồn tại");
                return;
            }
            else if(!DangNhapController.kiemTraMatKhau(tendangnhap,Hash(matkhau)))
            {
                errorProvider1.SetError(this.txtpass, "Mật khẩu không đúng");
                return;
            }    
            
            frmMainSimpleNote h = new frmMainSimpleNote();
            this.Hide();
            h.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCreateAccountNote h = new frmCreateAccountNote();
            h.Show();
        }
        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
            //Source:https://www.it-swarm.dev/vi/c%23/bam-voi-thuat-toan-sha1-trong-c/1072926302/
        }
    }
}
