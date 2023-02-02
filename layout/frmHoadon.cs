using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace layout
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }


        private void frmHoadon_Load(object sender, EventArgs e)
        {
            loadHD();
        }

        private void loadHD()
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày lập", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Tổng tiền", System.Type.GetType("System.String"));
               
                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.HOADONs.ToList();
                    //  MessageBox.Show("gh");

                    foreach (HOADON hOADON in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                            hOADON.MAHOADON, hOADON.MAKHACHHANG, hOADON.MANHANVIEN, hOADON.NGAYLAP, hOADON.TONGTIEN   
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvHoadon.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvHoadon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmCTHD frmCTHD = new frmCTHD();
            frmCTHD.Show();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Ngày lập", System.Type.GetType("System.DateTime"));
                dataTable.Columns.Add("Tổng tiền", System.Type.GetType("System.String"));

                // dgvSanpham.DataSource = dataTable;
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    var data = db.HOADONs.SqlQuery("select *from HOADON where MAHOADON like '%" + txtTimkiem.Text + "%' or MAKHACHHANG like '%" + txtTimkiem.Text + "%' or MANHANVIEN like '%" + txtTimkiem.Text + "%'").ToList();
                    //  MessageBox.Show("gh");

                    foreach (HOADON hOADON in data)
                    {

                        dataTable.Rows.Add(new object[]
                        {
                            hOADON.MAHOADON, hOADON.MAKHACHHANG, hOADON.MANHANVIEN, hOADON.NGAYLAP, hOADON.TONGTIEN
                        });

                    }

                }
                // MessageBox.Show("gh");
                dgvHoadon.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime tngay = Convert.ToDateTime(dtimeTungay.Text);
        //    string tungay = tngay.ToString("dd-MM-yyyy");
            
        //    DateTime dngay = Convert.ToDateTime(dtimeDenngay.Text);
        //    string denngay = dngay.ToString("dd-MM-yyyy");



        //    try
        //    {

        //        DataTable dataTable = new DataTable();
        //        dataTable.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Ngày lập", System.Type.GetType("System.DateTime"));
        //        dataTable.Columns.Add("Tổng tiền", System.Type.GetType("System.String"));

        //        // dgvSanpham.DataSource = dataTable;
        //        using (QLnhasachEntities db = new QLnhasachEntities())
        //        {

        //            var data = db.HOADONs.SqlQuery("select *from HOADON where NGAYLAP >= " + tngay.ToString("d") + "and NGAYLAP <= " + dngay.ToString("d") + "").ToList();
        //            //  MessageBox.Show("gh");

        //            foreach (HOADON hOADON in data)
        //            {

        //                dataTable.Rows.Add(new object[]
        //                {
        //                    hOADON.MAHOADON, hOADON.MAKHACHHANG, hOADON.MANHANVIEN, hOADON.NGAYLAP, hOADON.TONGTIEN
        //                });

        //            }

        //        }
        //        // MessageBox.Show("gh");
        //        dgvHoadon.DataSource = dataTable;
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        //{
        //    //DateTime dt = DateTime.ParseExact(Convert.ToDateTime(dtimeTungay.Text).ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

        //    //string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

        //   // DateTime date = Convert.ToDateTime(dtimeTungay.Text);
        //   // string formatted = date.ToString("dd/M/yyyy");


        //   //// string  Convert.ToDateTime(dtimeTungay.Text);
        //   // MessageBox.Show(formatted);


        //    DateTime tngay = Convert.ToDateTime(dtimeTungay.Text);
        //    string tungay = tngay.ToString("dd-MM-yyyy");

        //    DateTime dngay = Convert.ToDateTime(dtimeDenngay.Text);
        //    string denngay = dngay.ToString("dd-MM-yyyy");



        //    try
        //    {

        //        DataTable dataTable = new DataTable();
        //        dataTable.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
        //        dataTable.Columns.Add("Ngày lập", System.Type.GetType("System.DateTime"));
        //        dataTable.Columns.Add("Tổng tiền", System.Type.GetType("System.String"));

        //        // dgvSanpham.DataSource = dataTable;
        //        using (QLnhasachEntities db = new QLnhasachEntities())
        //        {

        //            var data = db.HOADONs.SqlQuery("select *from HOADON where NGAYLAP >= " + tngay.ToString("d") + "and NGAYLAP <= " + dngay.ToString("d") + "").ToList();
        //            //  MessageBox.Show("gh");

        //            foreach (HOADON hOADON in data)
        //            {

        //                dataTable.Rows.Add(new object[]
        //                {
        //                    hOADON.MAHOADON, hOADON.MAKHACHHANG, hOADON.MANHANVIEN, hOADON.NGAYLAP, hOADON.TONGTIEN
        //                });

        //            }

        //        }
        //        // MessageBox.Show("gh");
        //        dgvHoadon.DataSource = dataTable;
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void btnXuatbaocao_Click(object sender, EventArgs e)
        {
            frmReportHD frmReportTTsp = new frmReportHD();
            frmReportTTsp.Show();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Xuatexcel();
        }
        private void Xuatexcel()
        {
            //string saveExcelFile = @"D:\Nam 3\LTTQ\excel_report.xlsx";
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
           string  saveExcelFile = filePath;
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
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "F1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Danh sách hóa đơn";

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
                row23_MaSP.Value2 = "Mã Hóa đơn";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenSP.Merge();
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Mã Sản Phẩm";

                //Tạo Ô Xuất xứ sản phẩm :
                Range row23_XuatxuSP = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_XuatxuSP.Merge();
                row23_XuatxuSP.Font.Size = fontSizeTenTruong;
                row23_XuatxuSP.Font.Name = fontName;
                row23_XuatxuSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_XuatxuSP.ColumnWidth = 20;
                row23_XuatxuSP.Value2 = "Mã Nhân viên";

                //Tạo Ô Năm sản xuất sản phẩm :
                Range row23_NamsxSP = ws.get_Range("E2", "E3");//Cột C dòng 2 và dòng 3
                row23_NamsxSP.Merge();
                row23_NamsxSP.Font.Size = fontSizeTenTruong;
                row23_NamsxSP.Font.Name = fontName;
                row23_NamsxSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NamsxSP.ColumnWidth = 20;
                row23_NamsxSP.Value2 = "Ngày lập";

                //Tạo Ô số lượng sản phẩm :
                Range row23_SoluongSP = ws.get_Range("F2", "F3");//Cột C dòng 2 và dòng 3
                row23_SoluongSP.Merge();
                row23_SoluongSP.Font.Size = fontSizeTenTruong;
                row23_SoluongSP.Font.Name = fontName;
                row23_SoluongSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_SoluongSP.ColumnWidth = 20;
                row23_SoluongSP.Value2 = "Tổng tiền";


                //Tô màu vàng cho các côt tiêu đề 
                Range row23_CotTieuDe = ws.get_Range("A2", "F3");
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
                    var data = context.HOADONs.ToList();
                    foreach (HOADON sp in data)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, sp.MAHOADON, sp.MAKHACHHANG, sp.MANHANVIEN, sp.NGAYLAP.ToString() , sp.TONGTIEN};
                        Range rowData = ws.get_Range("A" + row, "F" + row);
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;
                    }
                }

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "F" + row));

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
    }
}
