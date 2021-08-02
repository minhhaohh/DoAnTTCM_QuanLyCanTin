using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReportThongKeNhapHang : Form
    {
        public frmReportThongKeNhapHang(DateTimePicker dtpTuNgay, DateTimePicker dtpDenNgay)
        {
            InitializeComponent();

            this.sp_getDataReportNhapHangTableAdapter.Fill(this.NHAPHANGDataSet.sp_getDataReportNhapHang, dtpTuNgay.Value, dtpDenNgay.Value);
            this.reportViewer1.RefreshReport();
        }

        private void frmReportThongKeNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NHAPHANGDataSet.sp_getDataReportNhapHang' table. You can move, or remove it, as needed.
        }
    }
}
