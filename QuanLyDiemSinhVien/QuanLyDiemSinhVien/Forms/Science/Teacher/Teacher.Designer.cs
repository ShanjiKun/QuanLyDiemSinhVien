namespace QuanLyDiemSinhVien.Forms.Science.Teacher
{
    partial class Teacher
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
            this.gIANG_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANG_VIENTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.gIANG_VIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANG_VIENBindingSource
            // 
            this.gIANG_VIENBindingSource.DataMember = "GIANG_VIEN";
            this.gIANG_VIENBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // gIANG_VIENTableAdapter
            // 
            this.gIANG_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANG_VIENTableAdapter = this.gIANG_VIENTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANG_VIENGridControl
            // 
            this.gIANG_VIENGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gIANG_VIENGridControl.DataSource = this.gIANG_VIENBindingSource;
            this.gIANG_VIENGridControl.Location = new System.Drawing.Point(3, 2);
            this.gIANG_VIENGridControl.MainView = this.gridView1;
            this.gIANG_VIENGridControl.Name = "gIANG_VIENGridControl";
            this.gIANG_VIENGridControl.Size = new System.Drawing.Size(768, 220);
            this.gIANG_VIENGridControl.TabIndex = 1;
            this.gIANG_VIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gIANG_VIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 330);
            this.Controls.Add(this.gIANG_VIENGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource gIANG_VIENBindingSource;
        private QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANG_VIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}