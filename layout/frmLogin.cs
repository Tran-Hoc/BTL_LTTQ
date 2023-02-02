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
    public partial class frmLogin : Form
    {

        static public string quyen;
        public frmLogin()
        {
            InitializeComponent();
        }
        static public string user;
        public string Quyen { get => quyen; set => quyen = value; }
        public string User { get => user; set => user = value; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string tendn =  txtTendangnhap.Text;
            string mk = txtmatkhau.Text;
            using (QLnhasachEntities db = new QLnhasachEntities())
            {
                TAIKHOAN data = db.TAIKHOANs.Where(s => s.USERNAME == tendn).FirstOrDefault();
                if(data == null)
                {
                    MessageBox.Show("Sai tên đăng nhập");
                   
                }
                else if (!data.PASSWORD.Equals(mk))
                {
                    MessageBox.Show("Sai mật khẩu");
                }
                else
                {
                    quyen = data.QUYEN.ToString();
                    user = data.USERNAME;
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }

            }
        }
    }
}
