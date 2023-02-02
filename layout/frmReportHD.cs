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
    public partial class frmReportHD : Form
    {
        public frmReportHD()
        {
            InitializeComponent();
        }

        private void frmReportHD_Load(object sender, EventArgs e)
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
                    List<HOADON> listsp = db.HOADONs.ToList();
                    ReportDataSource rds = new ReportDataSource("DataSetHD", listsp);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
