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
    public partial class frmReportThongKeDoanhThu : Form
    {
        public frmReportThongKeDoanhThu(DateTimePicker dtpTuNgay, DateTimePicker dtpDenNgay)
        {
            InitializeComponent();

            this.sp_getDataReportDoanhThuTableAdapter.Fill(this.DOANHTHUDataSet.sp_getDataReportDoanhThu, dtpTuNgay.Value, dtpDenNgay.Value);
            this.reportViewer1.RefreshReport();
        }

        private void frmReportThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DOANHTHUDataSet.sp_getDataReportDoanhThu' table. You can move, or remove it, as needed.
        }
    }
}
