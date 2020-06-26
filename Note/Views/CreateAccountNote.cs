using Note.Controllers;
using Note.Models;
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
    public partial class frmCreateAccountNote : Form
    {
        public frmCreateAccountNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tendangnhap = this.txtdangnhap.Text.Trim();
            string matkhau = this.txtmatkhau.Text.Trim();
            string xacnhanmatkhau = this.txtmatkhau2.Text.Trim();
            if (tendangnhap=="")
            {
                errorProvider1.SetError(this.txtdangnhap, "Hãy nhập tên đăng nhập");
                return;
            }
            else if (matkhau == "")
            {
                errorProvider1.SetError(this.txtmatkhau, "Hãy nhập mật khẩu");
                return;
            }
            else if (xacnhanmatkhau == "")
            {
                errorProvider1.SetError(this.txtmatkhau2, "Hãy nhập mật khẩu");
                return;
            }
            else if(DangNhapController.kiemTraTenDangNhapDaTonTai(tendangnhap))
            {
                errorProvider1.SetError(this.txtdangnhap, "Tên đăng nhập đã tồn tại");
                return;
            }    
            BangDangNhap taiKhoan = new BangDangNhap();
            taiKhoan.TenDangNhap = tendangnhap;
            taiKhoan.MatKhau = Hash(matkhau); 
            DangNhapController.ThemTaiKhoan(taiKhoan);
            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
            //Source:https://www.it-swarm.dev/vi/c%23/bam-voi-thuat-toan-sha1-trong-c/1072926302/
        }

        
    }
}
