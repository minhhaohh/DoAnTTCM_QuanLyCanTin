
namespace GUI
{
    partial class frmReportHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONDataSet = new GUI.HOADONDataSet();
            this.sp_getDataReportHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getDataReportHoaDonTableAdapter = new GUI.HOADONDataSetTableAdapters.sp_getDataReportHoaDonTableAdapter();
            this.sp_getDataReportCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getDataReportCTHDTableAdapter = new GUI.HOADONDataSetTableAdapters.sp_getDataReportCTHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportCTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HOADONDataSet";
            reportDataSource1.Value = this.sp_getDataReportHoaDonBindingSource;
            reportDataSource2.Name = "CTHDDataSet";
            reportDataSource2.Value = this.sp_getDataReportCTHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // HOADONDataSet
            // 
            this.HOADONDataSet.DataSetName = "HOADONDataSet";
            this.HOADONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_getDataReportHoaDonBindingSource
            // 
            this.sp_getDataReportHoaDonBindingSource.DataMember = "sp_getDataReportHoaDon";
            this.sp_getDataReportHoaDonBindingSource.DataSource = this.HOADONDataSet;
            // 
            // sp_getDataReportHoaDonTableAdapter
            // 
            this.sp_getDataReportHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getDataReportCTHDBindingSource
            // 
            this.sp_getDataReportCTHDBindingSource.DataMember = "sp_getDataReportCTHD";
            this.sp_getDataReportCTHDBindingSource.DataSource = this.HOADONDataSet;
            // 
            // sp_getDataReportCTHDTableAdapter
            // 
            this.sp_getDataReportCTHDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHoaDon";
            this.Text = "frmReportHoaDon";
            this.Load += new System.EventHandler(this.frmReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportCTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_getDataReportHoaDonBindingSource;
        private HOADONDataSet HOADONDataSet;
        private System.Windows.Forms.BindingSource sp_getDataReportCTHDBindingSource;
        private HOADONDataSetTableAdapters.sp_getDataReportHoaDonTableAdapter sp_getDataReportHoaDonTableAdapter;
        private HOADONDataSetTableAdapters.sp_getDataReportCTHDTableAdapter sp_getDataReportCTHDTableAdapter;
    }
}