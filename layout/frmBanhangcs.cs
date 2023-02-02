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
    public partial class frmBanhangcs : Form
    {
        public frmBanhangcs()
        {
            InitializeComponent();
        }
      
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dgvGoiytt.DataSource = dataTable;

                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    //  var data = db.SANPHAMs.ToList();
                    var dataSearch = db.SANPHAMs.SqlQuery("Select * from SANPHAM where MASANPHAM like '%" + txtMasp.Text + "%' or TENSANPHAM like '%" + txtMasp.Text + "%' ").ToList();
                    //  MessageBox.Show("gh");

                    foreach (SANPHAM sanpham in dataSearch)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM, sanpham.GIABAN.ToString(), sanpham.DVT
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvGoiytt.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmBanhangcs_Load(object sender, EventArgs e)
        {
            loadTTform();
        }



        private void loadTTform()
        {
            lblNgay.Text = DateTime.Now.ToString();
            lblMakhach.Text =  CheckidKH(AUTO_ID_KHACH());
          //  frmDangnhap.id;
            lblManhanvien.Text = frmLogin.user;// LAY ID TU NHAN VIEN DANG NHAP
            lblMahoadon.Text = CheckidHD( AUTO_ID_HOADON());

            // danh  sach san pham mua 
                DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
            dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Giá", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Thành tiền", System.Type.GetType("System.String"));

            dgvDSspmua.DataSource = dataTable;

            //Ds sach san pham 
            try
            {

                DataTable dataTable1 = new DataTable();
                dataTable1.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable1.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable1.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                dataTable1.Columns.Add("DVT", System.Type.GetType("System.String"));
                dgvGoiytt.DataSource = dataTable1;

                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    //  var data = db.SANPHAMs.ToList();
                    var dataSearch = db.SANPHAMs.ToList();
                    //  MessageBox.Show("gh");

                    foreach (SANPHAM sanpham in dataSearch)
                    {

                        dataTable1.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM, sanpham.GIABAN.ToString(), sanpham.DVT
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvGoiytt.DataSource = dataTable1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        int countId = 0;
        // tang khoa chinh tu dong
    
        private string AUTO_ID_HOADON()
        {
            using (QLnhasachEntities db = new QLnhasachEntities())
            {
                var data = db.HOADONs.ToList();
                int index = data.Count();
              //  MessageBox.Show(index.ToString());
            }
            string id_auto;
            id_auto = "HD" + countId.ToString();
            // countId = 0;
            return id_auto;
        }

        private string AUTO_ID_KHACH()
        {
            using (QLnhasachEntities db = new QLnhasachEntities())
            {
                var data = db.KHACHHANGs.ToList();
                int index = data.Count();
              //  MessageBox.Show(index.ToString());
            }
            string id_auto;
            id_auto = "KH" + countId.ToString();
            // countId = 0;
            return id_auto;
        }

        //kiem tra trung lap khoa chinh
        private string CheckidHD(string Masp)
        {
            // SANPHAM sanpham = getSanPham();
            using (QLnhasachEntities db = new QLnhasachEntities())
            {

                var sp = db.HOADONs.Find(Masp);

                //  MessageBox.Show(sp.MASANPHAM.ToString());
                if (sp != null)
                {
                    countId++;
                    Masp = AUTO_ID_HOADON();
                    // MessageBox.Show(countId.ToString());
                    return CheckidHD(Masp);
                }
                else
                {
                  //  MessageBox.Show("ok");
                    return Masp;
                }

            }
        }
        //kiem tra trung lap khoa chinh
        private string CheckidKH(string Masp)
        {
            // SANPHAM sanpham = getSanPham();
            using (QLnhasachEntities db = new QLnhasachEntities())
            {

                var sp = db.KHACHHANGs.Find(Masp);

                //  MessageBox.Show(sp.MASANPHAM.ToString());
                if (sp != null)
                {
                    countId++;
                    Masp = AUTO_ID_KHACH();
                    // MessageBox.Show(countId.ToString());
                    return CheckidKH(Masp);
                }
                else
                {
                  //  MessageBox.Show("ok");
                    return Masp;
                }

            }
        }
        string masp = "";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmTTSanpham frmTTSanpham = new frmTTSanpham();
            frmTTSanpham.Show();
            
           
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            insertdata();

        }
        double tong = 0;
        private void insertdata()
        {
            

            string dvt;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    masp = frmTTSanpham.masp;
                    //   MessageBox.Show(masp.ToString());
                    SANPHAM data = db.SANPHAMs.Where(s => s.MASANPHAM == masp).FirstOrDefault();
                    txtMasp.Text = data.MASANPHAM;
                    txtTensp.Text = data.TENSANPHAM;
                    txtGia.Text = data.GIABAN.ToString();
                    dvt = data.DVT;

                }


                string soluong = txtSoluong.Text;

                double thanhtien = Convert.ToInt32(txtGia.Text) * Convert.ToInt32(soluong);
                txtThanhtien.Text = thanhtien.ToString();
                tong += thanhtien;
                txtTonggt.Text = tong.ToString();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Thành tiền", System.Type.GetType("System.String"));

                dgvDSspmua.DataSource = dataTable;

                dataTable.Rows.Add(new object[]
                        {
                           masp, txtTensp.Text, dvt , txtGia.Text, soluong, thanhtien.ToString()
                        });

                dgvDSspmua.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            string index = txtSoluong.Text;
            int solg = Convert.ToInt32(index);
            solg--;
            txtSoluong.Text = solg.ToString();
            Tinhgia();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            string index = txtSoluong.Text;
            int solg = Convert.ToInt32(index);
            solg++;
            txtSoluong.Text = solg.ToString();
            Tinhgia();
        }
        int soluong = 0;
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (txtSoluong.Text != "")
                    soluong = Convert.ToInt32(txtSoluong.Text);
                else
                    soluong = 0;
            }
            catch(Exception ex)
            {
                txtSoluong.Text = soluong.ToString();
            }
        }
        private void resetInputsp()
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtSoluong.Text = "1";
            txtGia.Text = "";
            txtDVT.Text = "";
            txtThanhtien.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetInputsp();
        }

        private void btnHuydon_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuXuathoadon_Click(object sender, EventArgs e)
        {
            HOADON hOADON  = getHoadon();
            hOADON.MAHOADON = lblMahoadon.Text;
         //   getCTHD();

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(hOADON).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getCTHD()
        {
            // List<CTHD> cthd = new List<CTHD>();
            foreach (DataGridViewRow dr in dgvDSspmua.Rows)
            {
                CTHD cTHD = new CTHD();
                cTHD.MASANPHAM = dr.Cells[0].Value.ToString();
                cTHD.SOLUONG = Convert.ToInt32(dr.Cells[4].Value.ToString());
                cTHD.GIABAN = Convert.ToDouble(dr.Cells[3].Value.ToString());
                cTHD.MAHOADON = lblMahoadon.Text;
                try
                {
                    using (QLnhasachEntities db = new QLnhasachEntities())
                    {
                        db.Entry(cTHD).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //var Result = dataGridView1.Rows.OfType<DataGridViewRow>().Select(
            //r => r.Cells.OfType<DataGridViewCell>().ToDictionary(c => dataGridView1.Columns[c.OwningColumn].HeaderText, c => (c.Value ?? "").ToString()
            //    ).ToList();


        }

        private HOADON getHoadon()
        {
            HOADON hoadon = new HOADON();
            try
            {
                hoadon.MAHOADON = lblMahoadon.Text;
                hoadon.MAKHACHHANG = lblMakhach.Text;
                hoadon.MANHANVIEN = lblManhanvien.Text;
                hoadon.NGAYLAP = Convert.ToDateTime(lblNgay.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return hoadon;
        }
        private void getTTsp()
        {
            CTHD cTHD = new CTHD();
            cTHD.MAHOADON = lblMahoadon.Text;
            cTHD.MASANPHAM = ctmasp;
            cTHD.GIABAN = Convert.ToDouble(txtThanhtien.Text);

        }
        List<CTHD> listCthd = new List<CTHD>();
        private void btnTieptheo_Click(object sender, EventArgs e)
        {
            loadctsp();
            resetInputsp();
        }
        private void Tinhgia()
        {
            string soluong = txtSoluong.Text;
            string gia = txtGia.Text;
            int slg = Convert.ToInt32(soluong);
            double gi = Convert.ToDouble(gia);
            double thanhtien = gi * slg;
            txtThanhtien.Text = thanhtien.ToString();
        }
        // in data len ds san pham
        private void loadctsp()
        {

            try
            {
                CTHD cTHD = new CTHD();
                cTHD.MAHOADON = lblMahoadon.Text;
                cTHD.MASANPHAM = ctmasp;
                cTHD.SOLUONG = Convert.ToInt32(txtSoluong.Text);
                cTHD.GIABAN = Convert.ToDouble(txtThanhtien.Text); // gia ban => thanh tien 
                listCthd.Add(cTHD);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Thành tiền", System.Type.GetType("System.String"));
                dgvDSspmua.DataSource = dataTable;

                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    

                    foreach(CTHD cTHD1 in listCthd)
                    {
                        SANPHAM sanpham = db.SANPHAMs.Where(s => s.MASANPHAM == cTHD.MASANPHAM).FirstOrDefault();
                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM, sanpham.DVT, sanpham.GIABAN, cTHD.SOLUONG, cTHD.GIABAN
                        });
                    }
                      
                }

                dgvGoiytt.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string ctmasp ="";
        private void dgvGoiytt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dataGridView = dgvGoiytt.Rows[e.RowIndex];
                    ctmasp = dataGridView.Cells[0].Value.ToString();
                    txtTensp.Text = dataGridView.Cells[1].Value.ToString();
                    txtGia.Text = dataGridView.Cells[2].Value.ToString();
                    txtDVT.Text = dataGridView.Cells[3].Value.ToString();

                    Tinhgia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvGoiytt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
