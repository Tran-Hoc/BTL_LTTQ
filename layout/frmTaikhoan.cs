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
    public partial class frmTaikhoan : Form
    {
        public frmTaikhoan()
        {
            InitializeComponent();
        }
        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            loadDsTk();
        }

        private bool checkUsername(string username) {
            bool ck =true;
            try
            {
                using(QLnhasachEntities db = new QLnhasachEntities())
                {
                    var check = db.TAIKHOANs.Where(s => s.USERNAME == username).FirstOrDefault();
                    if(check != null)
                    {
                        ck = false;
                    }
                    else
                    {
                        ck = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ck;
        }


        private void btnThemtaikhoan_Click(object sender, EventArgs e)
        {
            if (!checkUsername(txtTenTk.Text.ToString()))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại");
                return;
            }
            TAIKHOAN tAIKHOAN = getTaikhoan();
            tAIKHOAN.ID = Checkid(tAIKHOAN.ID.ToString());
           

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(tAIKHOAN).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();

                }
                loadDsTk();
                resetTTtk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // lam moi o nhap thong tin
        private void resetTTtk()
        {
            txtID.Text = "";
            txtTenTk.Text = "";
            txtMatkhau.Text = "";
            cbquyen.SelectedIndex = -1;
        }
        // tai len danh sach tu database
        private void loadDsTk()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã số", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên tài khoản", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mật khẩu", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Quyền", System.Type.GetType("System.String"));

                dgvDstaikhoan.DataSource = dataTable;

                DataTable dataDSnv = new DataTable();
                dataDSnv.Columns.Add("Mã số", System.Type.GetType("System.String"));
                dataDSnv.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dataDSnv.Columns.Add("Công việc", System.Type.GetType("System.String"));

                dgvTTNhanvien.DataSource = dataDSnv;


                using (QLnhasachEntities db = new QLnhasachEntities())
                {

                    var data = db.TAIKHOANs.ToList();

                    countId = 1;
                    // MessageBox.Show(countId.ToString());

                    foreach (TAIKHOAN tAIKHOAN in data)
                    {
                        countId++;
                        //Console.WriteLine(countId);
                        dataTable.Rows.Add(new object[]
                        {
                            tAIKHOAN.ID, tAIKHOAN.USERNAME, tAIKHOAN.PASSWORD ,tAIKHOAN.QUYEN
                        });

                    }
                    //  MessageBox.Show(countId.ToString());

                    dgvDstaikhoan.DataSource = dataTable;

                    var datanv = db.NHANVIENs.ToList();

                    foreach(NHANVIEN nhanvien in datanv)
                    {
                        dataDSnv.Rows.Add(new object[]{
                            nhanvien.MANHANVIEN, nhanvien.TENNHANVIEN, nhanvien.CONGVIEC
                        });

                    }
                    dgvTTNhanvien.DataSource = dataDSnv;
                }

               
           
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }
        // kiem tra trung lap khoa chinh
        private string Checkid(string p)
        {
            using (QLnhasachEntities db = new QLnhasachEntities())
            {

                var sp = db.TAIKHOANs.Find(p);

                //  MessageBox.Show(sp.MASANPHAM.ToString());
                if (sp != null)
                {
                    countId++;
                    p = AUTO_ID();
                    // MessageBox.Show(countId.ToString());
                    return Checkid(p);
                }
                else
                {
                    MessageBox.Show("ok");
                    return p;
                }

            }
        }
        // lay thong tin tu textbox
        private TAIKHOAN getTaikhoan()
        {
            TAIKHOAN tAIKHOAN = new TAIKHOAN();
            tAIKHOAN.USERNAME = txtTenTk.Text;
            tAIKHOAN.PASSWORD = txtMatkhau.Text;
            tAIKHOAN.ID = AUTO_ID();
            tAIKHOAN.QUYEN =  Convert.ToByte(cbquyen.SelectedItem.ToString());
            return tAIKHOAN;
        }
        int countId = 0;
        // tang ma tu dong
        private string AUTO_ID()
        {
            string id_auto;
            id_auto = "TK" + countId.ToString();
            // countId = 0;
            return id_auto;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TAIKHOAN sANPHAM = new TAIKHOAN();
            sANPHAM.ID = txtID.Text;
            try
            {

                using (var context = new QLnhasachEntities())
                {
                    var deletedCustomer = context.TAIKHOANs.Where(c => c.ID == sANPHAM.ID).FirstOrDefault();
                    context.TAIKHOANs.Remove(deletedCustomer);
                    context.SaveChanges();
                }

                loadDsTk();
                resetTTtk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            TAIKHOAN sANPHAM = getTaikhoan();
            sANPHAM.ID = txtID.Text;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(sANPHAM).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                loadDsTk();
                resetTTtk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDstaikhoan_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dataGridView = dgvDstaikhoan.Rows[e.RowIndex];
                    txtID.Text = dataGridView.Cells[0].Value.ToString();
                    txtTenTk.Text = dataGridView.Cells[1].Value.ToString();
                    txtMatkhau.Text = dataGridView.Cells[2].Value.ToString();
                    cbquyen.SelectedItem = dataGridView.Cells[3].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvTTNhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dataGridView = dgvTTNhanvien.Rows[e.RowIndex];
                    txtTenTk.Text = dataGridView.Cells[0].Value.ToString();
                    txtMatkhau.Text = dataGridView.Cells[1].Value.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
