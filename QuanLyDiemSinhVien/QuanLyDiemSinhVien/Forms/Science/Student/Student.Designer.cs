namespace QuanLyDiemSinhVien.Forms.Science.Student
{
    partial class Student
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
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.sINH_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINH_VIENTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.SINH_VIENTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.sINH_VIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINH_VIENBindingSource
            // 
            this.sINH_VIENBindingSource.DataMember = "SINH_VIEN";
            this.sINH_VIENBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // sINH_VIENTableAdapter
            // 
            this.sINH_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = this.sINH_VIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINH_VIENGridControl
            // 
            this.sINH_VIENGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sINH_VIENGridControl.DataSource = this.sINH_VIENBindingSource;
            this.sINH_VIENGridControl.Location = new System.Drawing.Point(0, 1);
            this.sINH_VIENGridControl.MainView = this.gridView1;
            this.sINH_VIENGridControl.Name = "sINH_VIENGridControl";
            this.sINH_VIENGridControl.Size = new System.Drawing.Size(744, 220);
            this.sINH_VIENGridControl.TabIndex = 1;
            this.sINH_VIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sINH_VIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 262);
            this.Controls.Add(this.sINH_VIENGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINH_VIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource sINH_VIENBindingSource;
        private QLDSVDataSet_TablesTableAdapters.SINH_VIENTableAdapter sINH_VIENTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sINH_VIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}