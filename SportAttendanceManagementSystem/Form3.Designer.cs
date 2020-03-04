namespace SportAttendanceManagementSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sportDataSet = new SportAttendanceManagementSystem.sportDataSet();
            this.sportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presenceTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.presenceTableAdapter();
            this.sportsTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.sportsTableAdapter();
            this.universityTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.universityTableAdapter();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new SportAttendanceManagementSystem.sportDataSetTableAdapters.studentsTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SportAttendanceManagementSystem.sportDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "sportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportsBindingSource
            // 
            this.sportsBindingSource.DataMember = "sports";
            // 
            // presenceTableAdapter
            // 
            this.presenceTableAdapter.ClearBeforeFill = true;
            // 
            // sportsTableAdapter
            // 
            this.sportsTableAdapter.ClearBeforeFill = true;
            // 
            // universityTableAdapter
            // 
            this.universityTableAdapter.ClearBeforeFill = true;
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataMember = "university";
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            // 
            // presenceBindingSource
            // 
            this.presenceBindingSource.DataMember = "presence";
            this.presenceBindingSource.DataSource = this.sportDataSet;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
            this.studentsBindingSource1.DataSource = this.sportDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.presenceTableAdapter = this.presenceTableAdapter;
            this.tableAdapterManager.sportsTableAdapter = this.sportsTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.universityTableAdapter = this.universityTableAdapter;
            this.tableAdapterManager.UpdateOrder = SportAttendanceManagementSystem.sportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 345);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private sportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource sportsBindingSource;
        private sportDataSetTableAdapters.presenceTableAdapter presenceTableAdapter;
        private sportDataSetTableAdapters.sportsTableAdapter sportsTableAdapter;
        private sportDataSetTableAdapters.universityTableAdapter universityTableAdapter;
        private System.Windows.Forms.BindingSource universityBindingSource;
        private sportDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource presenceBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private sportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}