using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using DataTable = System.Data.DataTable;

namespace layout
{
    public partial class frmSanpham : Form
    {
        int countId = 0;
        // tang khoa chinh tu dong
        private string AUTO_ID()
        {
            string id_auto;
            id_auto = "SP" + countId.ToString();
            // countId = 0;
            return id_auto;
        }
        // dat ngay toi da cho datetime
        private void set_date()
        {
            DateTime dateTime = DateTime.Now;

            dtimeNSXsp.MaxDate = dateTime;
        }
        public frmSanpham()
        {
            InitializeComponent();
        }
        private void frmSanpham_Load(object sender, EventArgs e)
        {
            loadSP();
            //set_date();
        }
        #region Hien thi toan bo thong tin san pham
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
        // xem chi tiet thong tin san pham 
        private void dgvSanpham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewRow dataGridView = dgvTTSach.Rows[e.RowIndex];
            //txtMasach.Text = dataGridView.Cells[0].Value.ToString();


        }

        // dieu huong su kien den tabcontrol do dung ht ... hoac sach
        private void dgvSanpham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridView = dgvSanpham.Rows[e.RowIndex];
                string loai = dataGridView.Cells[6].Value.ToString();
                if (!loai.Equals("Sách"))
                {
                    tabcontrolSp.SelectedTab = tabPageTTsp;
                    try
                    {
                        if (e.RowIndex != -1 )
                        {

                            txtMasp.Text = dataGridView.Cells[0].Value.ToString();
                            txtTensp.Text = dataGridView.Cells[1].Value.ToString();
                            txtXuatxusp.Text = dataGridView.Cells[2].Value.ToString();
                            dtimeNSXsp.Value = Convert.ToDateTime(dataGridView.Cells[3].Value);
                            txtSoluongsp.Text = dataGridView.Cells[4].Value.ToString();
                            cbDvtsp.SelectedItem = dataGridView.Cells[5].Value.ToString();
                            cbLoaisp.SelectedItem = dataGridView.Cells[6].Value.ToString();
                            txtGianhap.Text = dataGridView.Cells[7].Value.ToString();
                            txtGiaban.Text = dataGridView.Cells[8].Value.ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    tabcontrolSp.SelectedTab = tabPageTTsach;
                    string idtt = dataGridView.Cells[0].Value.ToString();
                    try
                    {
                        using (QLnhasachEntities db = new QLnhasachEntities())
                        {
                            //var data = db.SANPHAMs.Where(s => (s.LOAI == "Sách" & s.MASANPHAM == idtt)).ToList();
                            var sanphamdata = db.SANPHAMs.SqlQuery("select * from SANPHAM where MASANPHAM = '" + idtt + "'").First();

                            //  List<SACH> daata = db.SACHes.Where(s=>s.MASANPHAM == data.;
                            //  countId = 1;
                            DataTable dataTable = new DataTable();

                            //  foreach (SANPHAM sanpham in data)
                            //    {
                            SACH sach = db.SACHes.Where(s => s.MASANPHAM == idtt).FirstOrDefault();
                            txtMasach.Text = sanphamdata.MASANPHAM;
                            txtTensach.Text = sanphamdata.TENSANPHAM;
                            txtTacgiasach.Text = sach.TENTACGIA;
                            txtXuatxusach.Text = sanphamdata.XUATXU;
                            txtNxbSach.Text = sach.NHAXUATBAN;
                            dtimeNxbsach.Value = Convert.ToDateTime(sanphamdata.NAMSANXUAT);
                            txtSoluongsach.Text = sanphamdata.SOLUONG.ToString();
                            txtLoaisach.Text = sach.LOAISACH;
                            txtGianhapSach.Text = sanphamdata.GIANHAP.ToString();
                            txtGiabansach.Text = sanphamdata.GIABAN.ToString();
                            txtMotasach.Text = sach.MOTA;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Xuatexcel();
        }
      
        private void Xuatexcel()
        {
            string saveExcelFile = @"D:\Nam 3\LTTQ\excel_report.xlsx";
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            using (SaveFileDialog dialog = new SaveFileDialog())
            {

                // chỉ lọc ra các file có định dạng Excel
                dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

                // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
            }
            saveExcelFile = filePath;
            try
            {


                // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                    return;
                }

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "J1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Thống kê sản phẩm";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaSP.Merge();
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Mã Sản Phẩm";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenSP.Merge();
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Tên Sản Phẩm";

                //Tạo Ô Xuất xứ sản phẩm :
                Range row23_XuatxuSP = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_XuatxuSP.Merge();
                row23_XuatxuSP.Font.Size = fontSizeTenTruong;
                row23_XuatxuSP.Font.Name = fontName;
                row23_XuatxuSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_XuatxuSP.ColumnWidth = 20;
                row23_XuatxuSP.Value2 = "Xuất xứ";

                //Tạo Ô Năm sản xuất sản phẩm :
                Range row23_NamsxSP = ws.get_Range("E2", "E3");//Cột C dòng 2 và dòng 3
                row23_NamsxSP.Merge();
                row23_NamsxSP.Font.Size = fontSizeTenTruong;
                row23_NamsxSP.Font.Name = fontName;
                row23_NamsxSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NamsxSP.ColumnWidth = 20;
                row23_NamsxSP.Value2 = "Năm sản xuất";

                //Tạo Ô số lượng sản phẩm :
                Range row23_SoluongSP = ws.get_Range("F2", "F3");//Cột C dòng 2 và dòng 3
                row23_SoluongSP.Merge();
                row23_SoluongSP.Font.Size = fontSizeTenTruong;
                row23_SoluongSP.Font.Name = fontName;
                row23_SoluongSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_SoluongSP.ColumnWidth = 20;
                row23_SoluongSP.Value2 = "Số lượng";

                //Tạo Ô dvt sản phẩm :
                Range row23_DvtSP = ws.get_Range("G2", "G3");//Cột C dòng 2 và dòng 3
                row23_DvtSP.Merge();
                row23_DvtSP.Font.Size = fontSizeTenTruong;
                row23_DvtSP.Font.Name = fontName;
                row23_DvtSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_DvtSP.ColumnWidth = 20;
                row23_DvtSP.Value2 = "Đơn vị tính";

                //Tạo Ô loại sản phẩm:
                Range row23_LoaiSP = ws.get_Range("H2", "H3");//Cột C dòng 2 và dòng 3
                row23_LoaiSP.Merge();
                row23_LoaiSP.Font.Size = fontSizeTenTruong;
                row23_LoaiSP.Font.Name = fontName;
                row23_LoaiSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_LoaiSP.ColumnWidth = 20;
                row23_LoaiSP.Value2 = "Loại Sản Phẩm";

                //Tạo Ô Giá Sản phẩm :
                Range row2_GiaSP = ws.get_Range("I2", "J2");//Cột D->E của dòng 2
                row2_GiaSP.Merge();
                row2_GiaSP.Font.Size = fontSizeTenTruong;
                row2_GiaSP.Font.Name = fontName;
                row2_GiaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_GiaSP.Value2 = "Giá Sản Phẩm";

                //Tạo Ô giá nhập Sản phẩm :
                Range row23_GianhapSP = ws.get_Range("I3", "I3");//Cột C dòng 2 và dòng 3
                row23_GianhapSP.Merge();
                row23_GianhapSP.Font.Size = fontSizeTenTruong;
                row23_GianhapSP.Font.Name = fontName;
                row23_GianhapSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_GianhapSP.ColumnWidth = 20;
                row23_GianhapSP.Value2 = "Giá nhập";

                //Tạo Ô giá bán Sản phẩm :
                Range row23_GiabanSP = ws.get_Range("J3", "J3");//Cột C dòng 2 và dòng 3
                row23_GiabanSP.Merge();
                row23_GiabanSP.Font.Size = fontSizeTenTruong;
                row23_GiabanSP.Font.Name = fontName;
                row23_GiabanSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_GiabanSP.ColumnWidth = 20;
                row23_GiabanSP.Value2 = "Giá bán";

                //Tô màu vàng cho các côt tiêu đề 
                Range row23_CotTieuDe = ws.get_Range("A2", "J3");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;
                using (QLnhasachEntities context = new QLnhasachEntities())
                {
                    var data = context.SANPHAMs.ToList();
                    foreach (SANPHAM sp in data)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, sp.MASANPHAM, sp.TENSANPHAM, sp.XUATXU, sp.NAMSANXUAT, sp.SOLUONG, sp.DVT, sp.LOAI, sp.GIANHAP, sp.GIANHAP };
                        Range rowData = ws.get_Range("A" + row, "J" + row);
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;
                    }
                }

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "J" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

        private void btnXuatbaocao_Click(object sender, EventArgs e)
        {
            frmReportTTsp frmReportTTsp = new frmReportTTsp();
            frmReportTTsp.Show();
        }
        #endregion


        #region thong tin san pham: do luu niem, do choi, do dung hoc tap

        //hien thi toan bo san pham: do choi, do luu niem, 
        private void loadTTsp()
        {

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    /*
                     * Đồ chơi
                       Đồ lưu niệm
                       Đồ dùng học tập
                     */

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
                    dgvTTsp.DataSource = dataTable;

                    var data = db.SANPHAMs.Where(s => (s.LOAI == "Đồ chơi" || s.LOAI == "Đồ lưu niệm" || s.LOAI == "Đồ dùng học tập")).ToList();

                    countId = 1;
                    // MessageBox.Show(countId.ToString());

                    foreach (SANPHAM sanpham in data)
                    {
                        countId++;
                        //Console.WriteLine(countId);
                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM, sanpham.XUATXU, sanpham.NAMSANXUAT,sanpham.SOLUONG, sanpham.DVT, sanpham.LOAI, sanpham.GIANHAP, sanpham.GIABAN
                        });

                    }
                    //  MessageBox.Show(countId.ToString());

                    dgvTTsp.DataSource = dataTable;

                }


            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }
        //lam moi o nhap thong tin
        private void resetTTsp()
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtXuatxusp.Text = "";
            dtimeNSXsp.Value = DateTime.Now;
            txtSoluongsp.Text = "";
            cbDvtsp.SelectedIndex = 0;
            cbLoaisp.SelectedIndex = 0;
            txtGianhap.Text = "";
            txtGiaban.Text = "";

        }
        //lay thong tin trong textbox phan nhap thong tin
        private SANPHAM getSanPham()
        {
            SANPHAM sanpham = new SANPHAM();
            try
            {

                sanpham.MASANPHAM = AUTO_ID();
                sanpham.TENSANPHAM = txtTensp.Text;
                sanpham.GIANHAP = Convert.ToDouble(txtGianhap.Text);
                sanpham.GIABAN = Convert.ToDouble(txtGiaban.Text);
                sanpham.NAMSANXUAT = Convert.ToDateTime(dtimeNSXsp.Text);
                //    sanpham.NAMSANXUAT = Convert.ToDateTime(dtimeNSXsp.Text;
                sanpham.XUATXU = txtXuatxusp.Text;
                sanpham.SOLUONG = Convert.ToInt32(txtSoluongsp.Text);
                sanpham.DVT = cbDvtsp.SelectedItem.ToString();
                sanpham.LOAI = cbLoaisp.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sanpham;
        }
        //kiem tra trung lap khoa chinh
        private string Checkid(string Masp)
        {
            // SANPHAM sanpham = getSanPham();
            using (QLnhasachEntities db = new QLnhasachEntities())
            {

                var sp = db.SANPHAMs.Find(Masp);

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
        //
        private void btnThemDungcuht_Click(object sender, EventArgs e)
        {
            SANPHAM sanpham = getSanPham();
            sanpham.MASANPHAM = Checkid(sanpham.MASANPHAM.ToString());

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(sanpham).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();

                }
                loadTTsp();
                resetTTsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCapnhatdungcuht_Click(object sender, EventArgs e)
        {
            SANPHAM sANPHAM = getSanPham();
            sANPHAM.MASANPHAM = txtMasp.Text;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(sANPHAM).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                loadTTsp();
                resetTTsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoasp_Click(object sender, EventArgs e)
        {
            SANPHAM sANPHAM = new SANPHAM();
            sANPHAM.MASANPHAM = txtMasp.Text;
            try
            {

                using (var context = new QLnhasachEntities())
                {
                    var deletedCustomer = context.SANPHAMs.Where(c => c.MASANPHAM == sANPHAM.MASANPHAM).FirstOrDefault();
                    context.SANPHAMs.Remove(deletedCustomer);
                    context.SaveChanges();
                }

                loadTTsp();
                resetTTsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        #region Xuat excel thong tin san pham dung cu hoc tap, ...
        private void btnXuatExcelsp_Click(object sender, EventArgs e)
        {

            try
            {
                string saveExcelFile = @"D:\Nam 3\LTTQ\excel_report.xlsx";
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "J1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Thống kê sản phẩm: Đồ chơi, dụng học tập, đồ lưu niệm";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaSP.Merge();
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Mã Sản Phẩm";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenSP.Merge();
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Tên Sản Phẩm";

                //Tạo Ô Xuất xứ sản phẩm :
                Range row23_XuatxuSP = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_XuatxuSP.Merge();
                row23_XuatxuSP.Font.Size = fontSizeTenTruong;
                row23_XuatxuSP.Font.Name = fontName;
                row23_XuatxuSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_XuatxuSP.ColumnWidth = 20;
                row23_XuatxuSP.Value2 = "Xuất xứ";

                //Tạo Ô Năm sản xuất sản phẩm :
                Range row23_NamsxSP = ws.get_Range("E2", "E3");//Cột C dòng 2 và dòng 3
                row23_NamsxSP.Merge();
                row23_NamsxSP.Font.Size = fontSizeTenTruong;
                row23_NamsxSP.Font.Name = fontName;
                row23_NamsxSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NamsxSP.ColumnWidth = 20;
                row23_NamsxSP.Value2 = "Năm sản xuất";

                //Tạo Ô số lượng sản phẩm :
                Range row23_SoluongSP = ws.get_Range("F2", "F3");//Cột C dòng 2 và dòng 3
                row23_SoluongSP.Merge();
                row23_SoluongSP.Font.Size = fontSizeTenTruong;
                row23_SoluongSP.Font.Name = fontName;
                row23_SoluongSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_SoluongSP.ColumnWidth = 20;
                row23_SoluongSP.Value2 = "Số lượng";

                //Tạo Ô dvt sản phẩm :
                Range row23_DvtSP = ws.get_Range("G2", "G3");//Cột C dòng 2 và dòng 3
                row23_DvtSP.Merge();
                row23_DvtSP.Font.Size = fontSizeTenTruong;
                row23_DvtSP.Font.Name = fontName;
                row23_DvtSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_DvtSP.ColumnWidth = 20;
                row23_DvtSP.Value2 = "Đơn vị tính";

                //Tạo Ô loại sản phẩm:
                Range row23_LoaiSP = ws.get_Range("H2", "H3");//Cột C dòng 2 và dòng 3
                row23_LoaiSP.Merge();
                row23_LoaiSP.Font.Size = fontSizeTenTruong;
                row23_LoaiSP.Font.Name = fontName;
                row23_LoaiSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_LoaiSP.ColumnWidth = 20;
                row23_LoaiSP.Value2 = "Loại Sản Phẩm";

                //Tạo Ô Giá Sản phẩm :
                Range row2_GiaSP = ws.get_Range("I2", "J2");//Cột D->E của dòng 2
                row2_GiaSP.Merge();
                row2_GiaSP.Font.Size = fontSizeTenTruong;
                row2_GiaSP.Font.Name = fontName;
                row2_GiaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_GiaSP.Value2 = "Giá Sản Phẩm";

                //Tạo Ô giá nhập Sản phẩm :
                Range row23_GianhapSP = ws.get_Range("I3", "I3");//Cột C dòng 2 và dòng 3
                row23_GianhapSP.Merge();
                row23_GianhapSP.Font.Size = fontSizeTenTruong;
                row23_GianhapSP.Font.Name = fontName;
                row23_GianhapSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_GianhapSP.ColumnWidth = 20;
                row23_GianhapSP.Value2 = "Giá nhập";

                //Tạo Ô giá bán Sản phẩm :
                Range row23_GiabanSP = ws.get_Range("J3", "J3");//Cột C dòng 2 và dòng 3
                row23_GiabanSP.Merge();
                row23_GiabanSP.Font.Size = fontSizeTenTruong;
                row23_GiabanSP.Font.Name = fontName;
                row23_GiabanSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_GiabanSP.ColumnWidth = 20;
                row23_GiabanSP.Value2 = "Giá bán";

                //Tô màu vàng cho các côt tiêu đề 
                Range row23_CotTieuDe = ws.get_Range("A2", "J3");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;
                using (QLnhasachEntities context = new QLnhasachEntities())
                {
                    var data = context.SANPHAMs.ToList();
                    foreach (SANPHAM sp in data)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, sp.MASANPHAM, sp.TENSANPHAM, sp.XUATXU, sp.NAMSANXUAT, sp.SOLUONG, sp.DVT, sp.LOAI, sp.GIANHAP, sp.GIANHAP };
                        Range rowData = ws.get_Range("A" + row, "J" + row);
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;
                    }
                }
                  
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "J" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        #endregion
        //xuat report
        private void btnXuatreportsp_Click(object sender, EventArgs e)
        {
            frmReportTTsp frmReportTTsp = new frmReportTTsp();
            frmReportTTsp.Show();
        }
        //lay thong tin tu datagridview len textbox
        private void dgvTTsp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dataGridView = dgvTTsp.Rows[e.RowIndex];
                    txtMasp.Text = dataGridView.Cells[0].Value.ToString();
                    txtTensp.Text = dataGridView.Cells[1].Value.ToString();
                    txtXuatxusp.Text = dataGridView.Cells[2].Value.ToString();
                    dtimeNSXsp.Value = Convert.ToDateTime(dataGridView.Cells[3].Value);
                    txtSoluongsp.Text = dataGridView.Cells[4].Value.ToString();
                    cbDvtsp.SelectedItem = dataGridView.Cells[5].Value.ToString();
                    cbLoaisp.SelectedItem = dataGridView.Cells[6].Value.ToString();
                    txtGianhap.Text = dataGridView.Cells[7].Value.ToString();
                    txtGiaban.Text = dataGridView.Cells[8].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //tim kiem thong tin san pham
        private void txtSearchTTsp_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    /*
                     * Đồ chơi
                       Đồ lưu niệm
                       Đồ dùng học tập
                     */

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
                    dgvTTsp.DataSource = dataTable;

                    //var data = db.SANPHAMs.Where(s => (s.LOAI == "Đồ chơi" || s.LOAI == "Đồ lưu niệm" || s.LOAI == "Đồ dùng học tập")).ToList(); LOAI NOT like %'Sách'% or
                    var dataSearch = db.SANPHAMs.SqlQuery("Select * from SANPHAM where  MASANPHAM like '%" + txtSearchTTsp.Text + "%' or TENSANPHAM like '%" + txtSearchTTsp.Text + "%' or XUATXU like '%" + txtSearchTTsp.Text + "%' or LOAI like'%" + txtSearchTTsp.Text + "%' or DVT like'%" + txtSearchTTsp.Text + "%'").ToList();
                    //  countId = 1;
                    // MessageBox.Show(countId.ToString());

                    foreach (SANPHAM sanpham in dataSearch)
                    {
                        // countId++;
                        //Console.WriteLine(countId);
                        if (sanpham.LOAI == "Sách")
                        {
                            continue;
                        }
                        dataTable.Rows.Add(new object[]
                        {
                            sanpham.MASANPHAM, sanpham.TENSANPHAM, sanpham.XUATXU, sanpham.NAMSANXUAT,sanpham.SOLUONG, sanpham.DVT, sanpham.LOAI, sanpham.GIANHAP, sanpham.GIABAN
                        });

                    }
                    //  MessageBox.Show(countId.ToString());

                    dgvTTsp.DataSource = dataTable;

                }


            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }
        #endregion


        #region Thong tin san pham: sach
        //hien thi toan bo san pham: sach
        private void loadTTSach()
        {
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    System.Data.DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Tác giả", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Xuất xứ", System.Type.GetType("System.String"));

                    dataTable.Columns.Add("Nhà xuất bản", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Năm xuất bản", System.Type.GetType("System.DateTime"));
                    dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                    //dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Thể loại", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Giá nhập", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Mô tả", System.Type.GetType("System.String"));

                    // lay du lieu sach trong san pham
                    var data = db.SANPHAMs.Where(s => s.LOAI == "Sách").ToList();
                    //  List<SACH> daata = db.SACHes.Where(s=>s.MASANPHAM == data.;
                    countId = 1;


                    foreach (SANPHAM sanpham in data)
                    {
                        // lay du lieu sach can thiet
                        SACH sach = db.SACHes.Where(s => s.MASANPHAM == sanpham.MASANPHAM).FirstOrDefault();
                        countId++;
                        //Console.WriteLine(countId);
                        dataTable.Rows.Add(new object[]
                        {
                                sanpham.MASANPHAM, sanpham.TENSANPHAM, sach.TENTACGIA, sanpham.XUATXU, sach.NHAXUATBAN, sach.NAMXUATBAN, sanpham.SOLUONG,/* sanpham.DVT*/ sach.LOAISACH, sanpham.GIANHAP, sanpham.GIABAN, sach.MOTA
                        });
                    }
                    dgvTTSach.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #region lay thong tin sach
        string idsach = "";
        private SANPHAM getTTspsach()
        {
            SANPHAM sanpham = new SANPHAM();
            try
            {
                idsach = AUTO_ID();
                sanpham.MASANPHAM = idsach;
                sanpham.TENSANPHAM = txtTensach.Text;
                sanpham.GIANHAP = Convert.ToDouble(txtGianhapSach.Text);
                sanpham.GIABAN = Convert.ToDouble(txtGiabansach.Text);
                sanpham.NAMSANXUAT = Convert.ToDateTime(dtimeNxbsach.Text);
                sanpham.XUATXU = txtXuatxusach.Text;
                sanpham.SOLUONG = Convert.ToInt32(txtSoluongsach.Text);
                sanpham.DVT = "quyen";
                sanpham.LOAI = "Sách";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sanpham;
        }
        private SACH getTTsach()
        {
            SACH sach = new SACH();
            try
            {
                // sach.MASANPHAM = idsach;
                sach.LOAISACH = txtLoaisach.Text;
                sach.TENTACGIA = txtTensach.Text;
                sach.NHAXUATBAN = txtNxbSach.Text;
                sach.NAMXUATBAN = Convert.ToDateTime(dtimeNxbsach.Text);
                sach.MOTA = txtMotasach.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sach;
        }
        #endregion
        //Dat lai vung nhap thong tin sach
        private void resetTTsach()
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            txtLoaisach.Text = "";
            txtGianhapSach.Text = "";
            txtGiabansach.Text = "";
            txtTacgiasach.Text = "";
            txtNxbSach.Text = "";
            txtXuatxusach.Text = "";
            dtimeNxbsach.Value = DateTime.Now;
            txtSoluongsach.Text = "";
            txtMotasach.Text = "";
        }
        // hien thi du lieu chi tiet len textbox
        private void dgvTTSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    DataGridViewRow dataGridView = dgvTTSach.Rows[e.RowIndex];
                    txtMasach.Text = dataGridView.Cells[0].Value.ToString();
                    txtTensach.Text = dataGridView.Cells[1].Value.ToString();
                    txtTacgiasach.Text = dataGridView.Cells[2].Value.ToString();
                    txtXuatxusach.Text = dataGridView.Cells[3].Value.ToString();

                    txtNxbSach.Text = dataGridView.Cells[4].Value.ToString();
                    dtimeNxbsach.Value = Convert.ToDateTime(dataGridView.Cells[5].Value);
                    txtSoluongsach.Text = dataGridView.Cells[6].Value.ToString();
                    txtLoaisach.Text = dataGridView.Cells[7].Value.ToString();
                    txtGianhapSach.Text = dataGridView.Cells[8].Value.ToString();
                    txtGiabansach.Text = dataGridView.Cells[9].Value.ToString();
                    txtMotasach.Text = dataGridView.Cells[10].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // them thong tin sach
        private void btnThemsach_Click(object sender, EventArgs e)
        {
            SANPHAM sanpham = getTTspsach();
            sanpham.MASANPHAM = Checkid(sanpham.MASANPHAM.ToString());
            SACH sach = getTTsach();
            sach.MASANPHAM = sanpham.MASANPHAM;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(sanpham).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    db.Entry(sach).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
                loadTTSach();
                resetTTsach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCapnhatsach_Click(object sender, EventArgs e)
        {
            SANPHAM sanpham = getTTspsach();
            sanpham.MASANPHAM = txtMasach.Text;
            SACH sach = getTTsach();
            sach.MASANPHAM = txtMasach.Text;
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    db.Entry(sanpham).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.Entry(sach).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                loadTTSach();
                resetTTsach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            SANPHAM sanpham = new SANPHAM();
            sanpham.MASANPHAM = txtMasach.Text;
            SACH sach = new SACH();
            sach.MASANPHAM = txtMasach.Text;
            try
            {

                using (QLnhasachEntities context = new QLnhasachEntities())
                {
                    var deletedCustomer = context.SANPHAMs.Where(c => c.MASANPHAM == sanpham.MASANPHAM).FirstOrDefault();
                    context.SANPHAMs.Remove(deletedCustomer);
                    context.SaveChanges();

                    var deleted = context.SACHes.Where(c => c.MASANPHAM == sach.MASANPHAM).FirstOrDefault();
                    context.SACHes.Remove(deleted);
                    context.SaveChanges();
                }
                using (QLnhasachEntities context = new QLnhasachEntities())
                {

                }
                loadTTsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void btnXuatexcelSach_Click(object sender, EventArgs e)
        {

        }
        private void btnXuatReportSach_Click(object sender, EventArgs e)
        {

        }
        // tim kiem thong tin sach
        private void txtSearchsach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    /*
                     * Đồ chơi
                       Đồ lưu niệm
                       Đồ dùng học tập
                     */

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Tác giả", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Xuất xứ", System.Type.GetType("System.String"));

                    dataTable.Columns.Add("Nhà xuất bản", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Năm xuất bản", System.Type.GetType("System.DateTime"));
                    dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                    //dataTable.Columns.Add("DVT", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Thể loại", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Giá nhập", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Giá bán", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Mô tả", System.Type.GetType("System.String"));
                    //  dgvTTSach.DataSource = dataTable;

                    //var data = db.SANPHAMs.Where(s => (s.LOAI == "Đồ chơi" || s.LOAI == "Đồ lưu niệm" || s.LOAI == "Đồ dùng học tập")).ToList(); LOAI NOT like %'Sách'% or
                    var dataSearch = db.SANPHAMs.SqlQuery("Select * from SANPHAM where  MASANPHAM like '%" + txtSearchTTsp.Text + "%' or TENSANPHAM like '%" + txtSearchTTsp.Text + "%' or XUATXU like '%" + txtSearchTTsp.Text + "%' or LOAI like'%" + txtSearchTTsp.Text + "%' or DVT like'%" + txtSearchTTsp.Text + "%'").ToList();

                    //  countId = 1;
                    // MessageBox.Show(countId.ToString());

                    foreach (SANPHAM sanpham in dataSearch)
                    {
                        //if (sanpham.LOAI == "Đồ chơi" || sanpham.LOAI == "Đồ lưu niệm" || sanpham.LOAI == "Đồ dùng học tập")
                        //{
                        //    MessageBox.Show("a");
                        //    continue;
                        //}
                        // MessageBox.Show(sanpham.MASANPHAM.ToString());
                        SACH sach = db.SACHes.Where(s => s.MASANPHAM == sanpham.MASANPHAM).FirstOrDefault();
                        if (sach == null)
                        {

                            continue;
                        }

                        //  countId++;
                        //Console.WriteLine(countId);
                        dataTable.Rows.Add(new object[]
                        {
                                sanpham.MASANPHAM, sanpham.TENSANPHAM, sach.TENTACGIA, sanpham.XUATXU, sach.NHAXUATBAN, sach.NAMXUATBAN, sanpham.SOLUONG,/* sanpham.DVT*/ sach.LOAISACH, sanpham.GIANHAP, sanpham.GIABAN, sach.MOTA
                        });
                        // MessageBox.Show(sanpham.MASANPHAM.ToString());
                    }
                    //  MessageBox.Show(countId.ToString());

                    dgvTTSach.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        /*
        #region Thong tin khuyen mai
        private DataTable drawtableDSkhuyenmai()
        {
            DataTable datatableDS = new DataTable();
            datatableDS.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
            datatableDS.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dgvDSspKhuyenmai.DataSource = datatableDS;
            return datatableDS;
        }
        //hien thi thong tin khuyen mai
        private void loadTTKhuyemai()
        {
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    System.Data.DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Mã khuyến mãi", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Tên khuyến mãi", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Giảm", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Ngày bắt đầu", System.Type.GetType("System.DateTime"));
                    dataTable.Columns.Add("Ngày kết thúc", System.Type.GetType("System.DateTime"));
                    dataTable.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                    dataTable.Columns.Add("Loại khách hàng", System.Type.GetType("System.String"));
                    dgvTTKhuyenmai.DataSource = dataTable;

                    DataTable datatableDS = new DataTable();
                    datatableDS.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                    datatableDS.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
                    dgvDSspKhuyenmai.DataSource = datatableDS;

                    var data = db.KHUYENMAIs.ToList();
                  
                   // var data = db.SANPHAMs.Where(s => s.LOAI == "Sách").ToList();

                    //  List<SACH> daata = db.SACHes.Where(s=>s.MASANPHAM == data.;
                    countId = 1;


                    foreach (KHUYENMAI Khuyenmai in data)
                    {
                      
                        countId++;
                        //Console.WriteLine(countId);
                        dataTable.Rows.Add(new object[]
                        {
                            Khuyenmai.MAKHUYENMAI, Khuyenmai.TENKHUYENMAI, Khuyenmai.GIAM, Khuyenmai.NGAYBATDAU, Khuyenmai.NGAYKETTHUC, Khuyenmai.SOLUONG, Khuyenmai.LOAIKHACHHANG
                        });
                    }
                    dgvTTKhuyenmai.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvTTKhuyenmai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dataGridView = dgvTTKhuyenmai.Rows[e.RowIndex];
                    string idkhuyenmai = dataGridView.Cells[0].Value.ToString();
                    txtMakhuyenmai.Text = idkhuyenmai;
                    txtTenkhuyenmai.Text = dataGridView.Cells[1].Value.ToString();
                    txtGiamkhuyenmai.Text = dataGridView.Cells[2].Value.ToString();
                    dtimeNgaybatdaukhuyenmai.Value = Convert.ToDateTime(dataGridView.Cells[3].Value);
                    DtimeNgayketthuckhuyenmai.Value = Convert.ToDateTime(dataGridView.Cells[4].Value);
                    txtSoluongkhuyenmai.Text = dataGridView.Cells[5].Value.ToString();
                    cbLoaikhachhangkhuyenmai.SelectedItem = dataGridView.Cells[6].Value.ToString();

                    DataTable datatableDS = new DataTable();
                    datatableDS.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                    datatableDS.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
                    datatableDS.Columns.Add("Số lượng mua", System.Type.GetType("System.String"));

                    System.Windows.Forms.Button btnyes = new Button();
                    btnyes.Text = "Yes";
                    

                    

                    dgvDSspKhuyenmai.DataSource = datatableDS;
                    
                    using(QLnhasachEntities db = new QLnhasachEntities())
                    {
                        var data = db.DSGIAMGIAs.Where(s => s.MADS == idkhuyenmai).ToList();

                        foreach (DSGIAMGIA dSGIAMGIA in data)
                        {
                            SANPHAM tensp = db.SANPHAMs.Where(s => s.MASANPHAM == dSGIAMGIA.MASANPHAM).FirstOrDefault();

                            datatableDS.Rows.Add(new object[]
                            {

                                     dSGIAMGIA.MASANPHAM,tensp.TENSANPHAM, dSGIAMGIA.SOLUONGMUA,

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnChonspkhuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void btnThemkhuyenmai_Click(object sender, EventArgs e)
        {

        }
        private void btnXoakhuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatexcelKhuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatreportkhuyemai_Click(object sender, EventArgs e)
        {

        }
        #endregion
        */
        //tai thong tin tung tabcontrol
        private void tabcontrolSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrolSp.SelectedTab == tabPageTTsp)
            {
                loadTTsp();
            }
            else if (tabcontrolSp.SelectedTab == tabPageSp)
            {
                loadSP();
            }
            else if (tabcontrolSp.SelectedTab == tabPageTTsach)
            {
                loadTTSach();
            }
            //else if (tabcontrolSp.SelectedTab == tabPageTTKhuyenmai)
            //{
            //    loadTTKhuyemai();
            //}
        }

      
    }
}
    

