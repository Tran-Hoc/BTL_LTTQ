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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            loadSP();
        }
        private void loadSP()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Tên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Xuất xứ", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Năm sản xuất", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Loại", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá nhập", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));

                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.SANPHAMs.ToList();

                    foreach (SANPHAM sanpham in data)
                    {
                        //  countId++;
                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM,  sanpham.XUATXU, sanpham.NAMSANXUAT.ToString(),sanpham.SOLUONG.ToString(), sanpham.DVT, sanpham.LOAI, sanpham.GIANHAP.ToString(), sanpham.GIABAN.ToString()
                        });

                    }
                    MessageBox.Show("a");
                    dgvSanpham.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
