namespace QuanLyDiemSinhVien.Forms.Science.Classes
{
    partial class Classes
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
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label tenLabel;
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maLopTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            maLopLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 0);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(877, 258);
            this.lOPGridControl.TabIndex = 1;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(54, 290);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(46, 13);
            maLopLabel.TabIndex = 1;
            maLopLabel.Text = "Ma Lop:";
            // 
            // maLopTextEdit
            // 
            this.maLopTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MaLop", true));
            this.maLopTextEdit.Location = new System.Drawing.Point(106, 287);
            this.maLopTextEdit.Name = "maLopTextEdit";
            this.maLopTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maLopTextEdit.TabIndex = 2;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(71, 330);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 3;
            tenLabel.Text = "Ten:";
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(106, 327);
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenTextEdit.TabIndex = 4;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 453);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextEdit);
            this.Controls.Add(maLopLabel);
            this.Controls.Add(this.maLopTextEdit);
            this.Controls.Add(this.lOPGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classes";
            this.Text = "Classes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit maLopTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
    }
}