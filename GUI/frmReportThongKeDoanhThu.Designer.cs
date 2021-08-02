
namespace GUI
{
    partial class frmReportThongKeDoanhThu
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
            this.sp_getDataReportDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOANHTHUDataSet = new GUI.DOANHTHUDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_getDataReportDoanhThuTableAdapter = new GUI.DOANHTHUDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOANHTHUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_getDataReportDoanhThuBindingSource
            // 
            this.sp_getDataReportDoanhThuBindingSource.DataMember = "sp_getDataReportDoanhThu";
            this.sp_getDataReportDoanhThuBindingSource.DataSource = this.DOANHTHUDataSet;
            // 
            // DOANHTHUDataSet
            // 
            this.DOANHTHUDataSet.DataSetName = "DOANHTHUDataSet";
            this.DOANHTHUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DOANHTHU";
            reportDataSource1.Value = this.sp_getDataReportDoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_getDataReportDoanhThuTableAdapter
            // 
            this.sp_getDataReportDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 409);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportThongKeDoanhThu";
            this.Text = "frmReportThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmReportThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOANHTHUDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_getDataReportDoanhThuBindingSource;
        private DOANHTHUDataSet DOANHTHUDataSet;
        private DOANHTHUDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter sp_getDataReportDoanhThuTableAdapter;
    }
}