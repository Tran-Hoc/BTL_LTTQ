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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            loadTTkhachhang();
        }
        private void loadTTkhachhang()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Đia chỉ", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Loại khách hàng", System.Type.GetType("System.String"));

                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.KHACHHANGs.ToList();
                    //  MessageBox.Show("gh");

                    foreach (KHACHHANG kHACHHANG in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                               kHACHHANG.MAKHACHHANG, kHACHHANG.TENKHACHHANG, kHACHHANG.NGAYSINH, kHACHHANG.SDT, kHACHHANG.DIACHI, kHACHHANG.LOAIKHACHHANG
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvTTkhachhang.DataSource = dataTable;
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
                dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Đia chỉ", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Loại khách hàng", System.Type.GetType("System.String"));

                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.KHACHHANGs.SqlQuery("Select * from KHACHHANG where MAKHACHHANG like '%" + txtSearchsp.Text + "%'or TENKHACHHANG like '%" + txtSearchsp.Text + "%' or SDT like '%" + txtSearchsp.Text + "%' ").ToList();
                    //  MessageBox.Show("gh"); 

                    foreach (KHACHHANG kHACHHANG in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                               kHACHHANG.MAKHACHHANG, kHACHHANG.TENKHACHHANG, kHACHHANG.NGAYSINH, kHACHHANG.SDT, kHACHHANG.DIACHI, kHACHHANG.LOAIKHACHHANG
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvTTkhachhang.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
