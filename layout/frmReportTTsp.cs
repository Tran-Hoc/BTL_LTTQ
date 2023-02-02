using Microsoft.Reporting.WinForms;
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
    public partial class frmReportTTsp : Form
    {
        public frmReportTTsp()
        {
            InitializeComponent();
        }

        private void frmReportTTsp_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            loadReport();
        }
        private void loadReport()
        {
            try
            {
                using (QLnhasachEntities db = new QLnhasachEntities())
                {
                    List<SANPHAM> listsp = db.SANPHAMs.ToList();
                    ReportDataSource rds = new ReportDataSource("DataSetTTsp", listsp);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
