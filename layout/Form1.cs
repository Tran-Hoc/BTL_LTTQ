using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace layout
{
    public partial class Form1 : Form
    {

        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public Form1()
        {

            InitializeComponent();
            string quyen = frmLogin.quyen;
            if(quyen == "2")
            {
                //btnTongquan.Enabled = false;
                btnTrangchu.Enabled = false;
               
                btnHoadon.Enabled = false;
                btnKhachhang.Enabled = false;
               // btnThongke.Enabled = false;
                btnTaikhoan.Enabled = false;
            }
            else if(quyen == "3")
            {
                //btnTongquan.Enabled = false;
                btnTrangchu.Enabled = false;
                btnSanpham.Enabled = false;
                btnHoadon.Enabled = false;
                btnKhachhang.Enabled = false;
               // btnThongke.Enabled = false;
                btnTaikhoan.Enabled = false;
            }
        
        }

        private void btnTongquan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTongquan());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangchu());

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangchu());
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanpham());
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoadon());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongke());
            //frmTest te = new frmTest();
            //te.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaikhoan());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachhang());
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanhangcs());
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
           
            OpenChildForm(new frmNhanvien());
        }
    }
}
