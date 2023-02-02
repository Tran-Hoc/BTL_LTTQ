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
    public partial class frmTTSanpham : Form
    {
        public frmTTSanpham()
        {
            InitializeComponent();

        }
        public static string masp;
       // frmBanhangcs frmBanhangcs = new frmBanhangcs(masp);
        private void dgvSanpham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridView = dgvSanpham.Rows[e.RowIndex];
                masp = (dataGridView.Cells[0].Value.ToString());
              //  insertdata();
                this.Close();
            
            }
        }
      
        

        private void frmTTSanpham_Load(object sender, EventArgs e)
        {
            loadSP();
        }
        // hien thi toan bo danh sach san pham
        private void loadSP()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Xuất xứ", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Năm sản xuất", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Loại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá nhập", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.SANPHAMs.ToList();
                    //  MessageBox.Show("gh");

                    foreach (SANPHAM sanpham in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM,  sanpham.XUATXU, sanpham.NAMSANXUAT ,sanpham.SOLUONG.ToString(), sanpham.DVT, 
                            sanpham.LOAI, sanpham.GIANHAP.ToString(), sanpham.GIABAN.ToString()
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvSanpham.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        // tim kiem trong toan bo danh sach san pham
        private void txtSearchsp_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Xuất xứ", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Năm sản xuất", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Loại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá nhập", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    //  var data = db.SANPHAMs.ToList();
                    var dataSearch = db.SANPHAMs.SqlQuery("Select * from SANPHAM where MASANPHAM like '%" + txtSearchsp.Text + "%' or TENSANPHAM like '%" + txtSearchsp.Text + "%' or XUATXU like '%" + txtSearchsp.Text + "%' or LOAI like'%" + txtSearchsp.Text + "%' or DVT like'%" + txtSearchsp.Text + "%'").ToList();
                    //  MessageBox.Show("gh");

                    foreach (SANPHAM sanpham in dataSearch)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM,  sanpham.XUATXU, sanpham.NAMSANXUAT ,sanpham.SOLUONG.ToString(), sanpham.DVT, sanpham.LOAI, sanpham.GIANHAP.ToString(), sanpham.GIABAN.ToString()
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvSanpham.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
