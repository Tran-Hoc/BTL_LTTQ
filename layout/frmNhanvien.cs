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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        int countId = 0;
        // tang khoa chinh tu dong
        private string AUTO_ID()
        {
            string id_auto;
            id_auto = "NV" + countId.ToString();
            // countId = 0;
            return id_auto;
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            loadDsNv();
        }

        private void tabcontrolNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabcontrolNhanvien.SelectedTab == tabPage1)
            {
                loadDsNv();
            }
            else if( tabcontrolNhanvien.SelectedTab == tabPage2)
            {
                loadTTnv();
            }
            else if(tabcontrolNhanvien.SelectedTab == tabPage3)
            {
                loadTTcv();
            }

        }
        #region Ds nhan vien
        // load ds nhan vien
        private void loadDsNv()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("CCCD", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Đia chỉ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Chức vụ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Hệ số lương", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Lương cơ bản", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Công việc", System.Type.GetType("System.String"));
              
                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.NHANVIENs.ToList();
                    //  MessageBox.Show("gh");

                    foreach (NHANVIEN nHANVIEN in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                                nHANVIEN.MANHANVIEN, nHANVIEN.TENNHANVIEN, nHANVIEN.NGAYSINH, nHANVIEN.SDT, nHANVIEN.CCCD, nHANVIEN.DIACHI, nHANVIEN.CHUCVU, nHANVIEN.HESOLUONG, nHANVIEN.LUONGCOBAN, nHANVIEN.NGAYVAOLAM, nHANVIEN.CONGVIEC
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvDanhsachvien.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void txtSearchsp_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("CCCD", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Đia chỉ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Chức vụ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Hệ số lương", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Lương cơ bản", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Công việc", System.Type.GetType("System.String"));

                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    // var data = db.NHANVIENs.ToList();   or CONGVIEC '%" + txtSearchNV.Text + "%'
                    var data = db.NHANVIENs.SqlQuery("Select * from NHANVIEN where MANHANVIEN like '%" + txtSearchNV.Text + "%'or TENNHANVIEN like '%" + txtSearchNV.Text + "%' or SDT like '%" + txtSearchNV.Text + "%'").ToList();
                    //  MessageBox.Show("gh");

                    foreach (NHANVIEN nHANVIEN in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                                nHANVIEN.MANHANVIEN, nHANVIEN.TENNHANVIEN, nHANVIEN.NGAYSINH, nHANVIEN.SDT, nHANVIEN.CCCD, nHANVIEN.DIACHI, nHANVIEN.CHUCVU, nHANVIEN.HESOLUONG, nHANVIEN.LUONGCOBAN, nHANVIEN.NGAYVAOLAM, nHANVIEN.CONGVIEC
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvDanhsachvien.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion
        #region Thong tin nhan vien
        // load thong tin chi tiet nv
        private void loadTTnv()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("CCCD", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Đia chỉ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Chức vụ", System.Type.GetType("System.String"));

                dataTable.Columns.Add("Hệ số lương", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Lương cơ bản", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));

                dataTable.Columns.Add("Công việc", System.Type.GetType("System.String"));

                dgvTTnhanvien.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    cbCongviecnv.Items.Clear();
                    // load tt tu database len cbox
                    var dataCongviec = db.DSCONGVIECs.ToList();
                    foreach (DSCONGVIEC dSCONGVIEC in dataCongviec)
                    {

                        cbCongviecnv.Items.Add(dSCONGVIEC.CONGVIEC.ToString());

                    }
                    var data = db.NHANVIENs.ToList();
                    countId = 1;
                    //  MessageBox.Show("gh");

                    foreach (NHANVIEN nHANVIEN in data)
                    {
                        countId++;
                        dataTable.Rows.Add(new object[]
                        {
                                nHANVIEN.MANHANVIEN, nHANVIEN.TENNHANVIEN, nHANVIEN.NGAYSINH, nHANVIEN.SDT, nHANVIEN.CCCD, nHANVIEN.DIACHI, nHANVIEN.CHUCVU, nHANVIEN.HESOLUONG, nHANVIEN.LUONGCOBAN, nHANVIEN.NGAYVAOLAM, nHANVIEN.CONGVIEC
                        });

                    }


                }

                // MessageBox.Show("gh");
                dgvTTnhanvien.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private NHANVIEN getNhanvien()
        {
            NHANVIEN nhanvien = new NHANVIEN();
            try
            {
                nhanvien.MANHANVIEN = AUTO_ID();
                nhanvien.TENNHANVIEN = txtTennv.Text;
                nhanvien.NGAYSINH = Convert.ToDateTime(dtimeNgaysinh.Text);
                nhanvien.SDT = txtSdtnv.Text;
                nhanvien.CCCD = txtCccdnv.Text;
                nhanvien.DIACHI = txtDiachinv.Text;
                nhanvien.CHUCVU = txtChucvunv.Text;
                nhanvien.HESOLUONG = Convert.ToDouble(txtHesoluongnv.Text);
                nhanvien.LUONGCOBAN = Convert.ToDouble(txtLuongcobannv.Text);
                nhanvien.NGAYVAOLAM = Convert.ToDateTime(dtimeNgayvaolam.Text);
                nhanvien.CONGVIEC = cbCongviecnv.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return nhanvien;
        }
        private string Checkid(string Masp)
        {
            // SANPHAM sanpham = getSanPham();
            using (QLnhasachEntities db = new QLnhasachEntities())
            {

                var sp = db.NHANVIENs.Find(Masp);

                //  MessageBox.Show(sp.MASANPHAM.ToString());
                if (sp != null)
                {
                    countId++;
                    Masp = AUTO_ID();
                    // MessageBox.Show(countId.ToString());
                    return Checkid(Masp);
                }
                else
                {
                    MessageBox.Show("ok");
                    return Masp;
                }

            }
        }
        private void resetTTnv()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            dtimeNgaysinh.Value = DateTime.Now;

            txtSdtnv.Text = "";
            txtCccdnv.Text = "";
            txtDiachinv.Text = "";
            txtChucvunv.Text = "";
            txtHesoluongnv.Text = "";
            txtLuongcobannv.Text = "";
            dtimeNgayvaolam.Value = DateTime.Now;
            cbCongviecnv.SelectedIndex = -1;
        }
        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = getNhanvien();

            nhanvien.MANHANVIEN = Checkid(nhanvien.MANHANVIEN.ToString());
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(nhanvien).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();

                }
                loadTTnv();
                resetTTnv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCapnhatnv_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = getNhanvien();

            nhanvien.MANHANVIEN = txtManv.Text;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(nhanvien).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();

                }
                loadTTnv();
                resetTTnv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHuynhanvien_Click(object sender, EventArgs e)
        {
            resetTTnv();
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            nhanvien.MANHANVIEN = txtManv.Text;
            try
            {

                using (var context = new QLnhasachEntities())
                {
                    var deletedCustomer = context.NHANVIENs.Where(c => c.MANHANVIEN == nhanvien.MANHANVIEN).FirstOrDefault();
                    context.NHANVIENs.Remove(deletedCustomer);
                    context.SaveChanges();
                }

                loadTTnv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void cbCongviecnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using(var db = new QLnhasachEntities())
                {
                    DSCONGVIEC luong = db.DSCONGVIECs.Where(c => c.CONGVIEC == cbCongviecnv.SelectedItem.ToString()).First();
                    txtLuongcobannv.Text = luong.LUONG.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // lay trong database
            
        }

        private void dgvTTnhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                     
                    DataGridViewRow dataGridView = dgvTTnhanvien.Rows[e.RowIndex];
                    txtManv.Text = dataGridView.Cells[0].Value.ToString();
                    txtTennv.Text = dataGridView.Cells[1].Value.ToString();
                    dtimeNgaysinh.Value =Convert.ToDateTime( dataGridView.Cells[2].Value);
                    txtSdtnv.Text = dataGridView.Cells[3].Value.ToString();
                    txtCccdnv.Text = dataGridView.Cells[4].Value.ToString();
                    txtDiachinv.Text = dataGridView.Cells[5].Value.ToString();
                    txtChucvunv.Text = dataGridView.Cells[6].Value.ToString();
                    txtHesoluongnv.Text = dataGridView.Cells[7].Value.ToString();
                    txtLuongcobannv.Text = dataGridView.Cells[8].Value.ToString();
                    dtimeNgayvaolam.Value = Convert.ToDateTime(dataGridView.Cells[9].Value);
                    cbCongviecnv.SelectedItem = dataGridView.Cells[10].Value.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        #region Cong viec 


        //load thong cong viec
        private void loadTTcv()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã công việc", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên công việc", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mức lương", System.Type.GetType("System.String"));

                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.DSCONGVIECs.ToList();
                    //  MessageBox.Show("gh");
                    countId = 1;
                    foreach (DSCONGVIEC dSCONGVIEC in data)
                    {
                        countId++;
                        dataTable.Rows.Add(new object[]
                        {
                            dSCONGVIEC.ID, dSCONGVIEC.CONGVIEC, dSCONGVIEC.LUONG
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvDanhsachcv.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       // them cong viec
        private void btnThemcv_Click(object sender, EventArgs e)
        {
            DSCONGVIEC dSCONGVIEC = getCongviec();
            dSCONGVIEC.ID = CheckidCV(dSCONGVIEC.ID.ToString());

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(dSCONGVIEC).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }

                loadTTcv();
                resetTTcv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void resetTTcv()
        {
            txtMacv.Text = "";
            txtCongviec.Text = "";
            txtLuongcv.Text = "";
        }

        private string CheckidCV(string v)
        {
            
                // SANPHAM sanpham = getSanPham();
                using (QLnhasachEntities db = new QLnhasachEntities())
                {

                    var sp = db.DSCONGVIECs.Find(v);

                    //  MessageBox.Show(sp.MASANPHAM.ToString());
                    if (sp != null)
                    {
                        countId++;
                        v = AUTO_ID();
                        // MessageBox.Show(countId.ToString());
                        return Checkid(v);
                    }
                    else
                    {
                        MessageBox.Show("ok");
                        return v;
                    }

                }
            
        }

        private DSCONGVIEC getCongviec()
        {
            DSCONGVIEC dSCONGVIEC = new DSCONGVIEC();
            try
            {
                dSCONGVIEC.ID = AUTO_IDCV();
                dSCONGVIEC.CONGVIEC = txtCongviec.Text;
                dSCONGVIEC.LUONG = Convert.ToInt32(txtLuongcv.Text);
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dSCONGVIEC;
        }
        private string AUTO_IDCV()
        {
            // tang khoa chinh tu dong
           
                string id_auto;
                id_auto = "CV" + countId.ToString();
                // countId = 0;
                return id_auto;
            
        }

        private void btnHuycv_Click(object sender, EventArgs e)
        {
            resetTTcv();
        }

        private void btnCapnhatcv_Click(object sender, EventArgs e)
        {
            DSCONGVIEC dscongviec = getCongviec();
            dscongviec.ID= txtMacv.Text;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(dscongviec).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                loadTTcv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoacv_Click(object sender, EventArgs e)
        {
            DSCONGVIEC dSCONGVIEC= new DSCONGVIEC();
            dSCONGVIEC.ID = txtMacv.Text;
            try
            {

                using (var context = new QLnhasachEntities())
                {
                    var deletedCustomer = context.DSCONGVIECs.Where(c => c.ID == dSCONGVIEC.ID).FirstOrDefault();
                    context.DSCONGVIECs.Remove(deletedCustomer);
                    context.SaveChanges();
                }

                loadTTcv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        #endregion

        private void dgvDanhsachcv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    DataGridViewRow dataGridView = dgvDanhsachcv.Rows[e.RowIndex];
                    txtMacv.Text = dataGridView.Cells[0].Value.ToString();
                    txtCongviec.Text = dataGridView.Cells[1].Value.ToString();
                    txtLuongcv.Text = dataGridView.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
