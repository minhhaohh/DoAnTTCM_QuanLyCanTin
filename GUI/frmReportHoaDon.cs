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
    public partial class frmReportHoaDon : Form
    {
        public frmReportHoaDon(int idHD)
        {
            InitializeComponent();

            // TODO: This line of code loads data into the 'HOADONDataSet.sp_getDataReportHoaDon' table. You can move, or remove it, as needed.
            this.sp_getDataReportHoaDonTableAdapter.Fill(this.HOADONDataSet.sp_getDataReportHoaDon, idHD);
            // TODO: This line of code loads data into the 'HOADONDataSet.sp_getDataReportCTHD' table. You can move, or remove it, as needed.
            this.sp_getDataReportCTHDTableAdapter.Fill(this.HOADONDataSet.sp_getDataReportCTHD, idHD);

            this.reportViewer1.RefreshReport();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
        }
    }
}
