namespace QuanLyDiemSinhVien.Forms.Report.StranStudent
{
    partial class StranStudentForm
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
            this.crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.qLDSVDataSet = new QuanLyDiemSinhVien.QLDSVDataSet();
            this.sP_StranStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_StranStudentTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.SP_StranStudentTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_StranStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crView
            // 
            this.crView.ActiveViewIndex = -1;
            this.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crView.Location = new System.Drawing.Point(0, 0);
            this.crView.Name = "crView";
            this.crView.Size = new System.Drawing.Size(615, 636);
            this.crView.TabIndex = 0;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_StranStudentBindingSource
            // 
            this.sP_StranStudentBindingSource.DataMember = "SP_StranStudent";
            this.sP_StranStudentBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sP_StranStudentTableAdapter
            // 
            this.sP_StranStudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StranStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 636);
            this.Controls.Add(this.crView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StranStudentForm";
            this.Text = "StranStudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StranStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_StranStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crView;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource sP_StranStudentBindingSource;
        private QLDSVDataSetTableAdapters.SP_StranStudentTableAdapter sP_StranStudentTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}