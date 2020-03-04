namespace SportAttendanceManagementSystem
{
    partial class Form_stare_promovare_studenti
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sportDataSet = new SportAttendanceManagementSystem.sportDataSet();
            this.presenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presenceTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.presenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.presenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SportAttendanceManagementSystem.Raport_stare_promovare_studenti.rdlc";
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
            // presenceBindingSource
            // 
            this.presenceBindingSource.DataMember = "presence";
            this.presenceBindingSource.DataSource = this.sportDataSet;
            // 
            // presenceTableAdapter
            // 
            this.presenceTableAdapter.ClearBeforeFill = true;
            // 
            // Form_stare_promovare_studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_stare_promovare_studenti";
            this.Text = "Form_stare_promovare_studenti";
            this.Load += new System.EventHandler(this.Form_stare_promovare_studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource presenceBindingSource;
        private sportDataSet sportDataSet;
        private sportDataSetTableAdapters.presenceTableAdapter presenceTableAdapter;
    }
}