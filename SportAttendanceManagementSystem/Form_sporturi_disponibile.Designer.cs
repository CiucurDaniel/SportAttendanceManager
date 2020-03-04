namespace SportAttendanceManagementSystem
{
    partial class Form_sporturi_disponibile
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sportDataSet = new SportAttendanceManagementSystem.sportDataSet();
            this.sportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.sportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.sportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SportAttendanceManagementSystem.Report_sporturi_disp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "sportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportsBindingSource
            // 
            this.sportsBindingSource.DataMember = "sports";
            this.sportsBindingSource.DataSource = this.sportDataSet;
            // 
            // sportsTableAdapter
            // 
            this.sportsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_sporturi_disponibile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_sporturi_disponibile";
            this.Text = "Raport Sporturi Disponibile      || Sport Attendance Manager";
            this.Load += new System.EventHandler(this.Form_sporturi_disponibile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sportsBindingSource;
        private sportDataSet sportDataSet;
        private sportDataSetTableAdapters.sportsTableAdapter sportsTableAdapter;
    }
}