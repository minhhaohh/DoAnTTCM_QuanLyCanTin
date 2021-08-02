
namespace GUI
{
    partial class frmReportThongKeNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_getDataReportNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHAPHANGDataSet = new GUI.NHAPHANGDataSet();
            this.sp_getDataReportDoanhThuTableAdapter1 = new GUI.DOANHTHUDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_getDataReportNhapHangTableAdapter = new GUI.NHAPHANGDataSetTableAdapters.sp_getDataReportNhapHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportNhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHAPHANGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_getDataReportNhapHangBindingSource
            // 
            this.sp_getDataReportNhapHangBindingSource.DataMember = "sp_getDataReportNhapHang";
            this.sp_getDataReportNhapHangBindingSource.DataSource = this.NHAPHANGDataSet;
            // 
            // NHAPHANGDataSet
            // 
            this.NHAPHANGDataSet.DataSetName = "NHAPHANGDataSet";
            this.NHAPHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_getDataReportDoanhThuTableAdapter1
            // 
            this.sp_getDataReportDoanhThuTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NHAPHANG";
            reportDataSource1.Value = this.sp_getDataReportNhapHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportNhapHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(943, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_getDataReportNhapHangTableAdapter
            // 
            this.sp_getDataReportNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportThongKeNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportThongKeNhapHang";
            this.Text = "frmReportThongKeNhapHang";
            this.Load += new System.EventHandler(this.frmReportThongKeNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportNhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHAPHANGDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DOANHTHUDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter sp_getDataReportDoanhThuTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_getDataReportNhapHangBindingSource;
        private NHAPHANGDataSet NHAPHANGDataSet;
        private NHAPHANGDataSetTableAdapters.sp_getDataReportNhapHangTableAdapter sp_getDataReportNhapHangTableAdapter;
    }
}