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
            System.Windows.Forms.Label maGVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label hocViLabel;
            System.Windows.Forms.Label hocHamLabel;
            System.Windows.Forms.Label chuyenMonLabel;
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.gIANG_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANG_VIENTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.gIANG_VIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.teId = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teDegree = new DevExpress.XtraEditors.TextEdit();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.tePro = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            maGVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            hocViLabel = new System.Windows.Forms.Label();
            hocHamLabel = new System.Windows.Forms.Label();
            chuyenMonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDegree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maGVLabel
            // 
            maGVLabel.AutoSize = true;
            maGVLabel.Location = new System.Drawing.Point(128, 266);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(43, 13);
            maGVLabel.TabIndex = 1;
            maGVLabel.Text = "Mã GV:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(129, 292);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(42, 13);
            hoTenLabel.TabIndex = 3;
            hoTenLabel.Text = "Họ tên:";
            // 
            // hocViLabel
            // 
            hocViLabel.AutoSize = true;
            hocViLabel.Location = new System.Drawing.Point(130, 318);
            hocViLabel.Name = "hocViLabel";
            hocViLabel.Size = new System.Drawing.Size(41, 13);
            hocViLabel.TabIndex = 5;
            hocViLabel.Text = "Học vị:";
            // 
            // hocHamLabel
            // 
            hocHamLabel.AutoSize = true;
            hocHamLabel.Location = new System.Drawing.Point(118, 344);
            hocHamLabel.Name = "hocHamLabel";
            hocHamLabel.Size = new System.Drawing.Size(53, 13);
            hocHamLabel.TabIndex = 7;
            hocHamLabel.Text = "Học hàm:";
            // 
            // chuyenMonLabel
            // 
            chuyenMonLabel.AutoSize = true;
            chuyenMonLabel.Location = new System.Drawing.Point(102, 370);
            chuyenMonLabel.Name = "chuyenMonLabel";
            chuyenMonLabel.Size = new System.Drawing.Size(69, 13);
            chuyenMonLabel.TabIndex = 9;
            chuyenMonLabel.Text = "Chuyên môn:";
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
            this.tableAdapterManager.CHUYEN_NGANHTableAdapter = null;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = this.gIANG_VIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager.PHONG_HOCTableAdapter = null;
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
            this.gIANG_VIENGridControl.Size = new System.Drawing.Size(967, 220);
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
            // teId
            // 
            this.teId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANG_VIENBindingSource, "MaGV", true));
            this.teId.Location = new System.Drawing.Point(177, 263);
            this.teId.Name = "teId";
            this.teId.Size = new System.Drawing.Size(100, 20);
            this.teId.TabIndex = 2;
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANG_VIENBindingSource, "HoTen", true));
            this.teName.Location = new System.Drawing.Point(177, 289);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(188, 20);
            this.teName.TabIndex = 4;
            // 
            // teDegree
            // 
            this.teDegree.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANG_VIENBindingSource, "HocVi", true));
            this.teDegree.Location = new System.Drawing.Point(177, 315);
            this.teDegree.Name = "teDegree";
            this.teDegree.Size = new System.Drawing.Size(100, 20);
            this.teDegree.TabIndex = 6;
            // 
            // teTitle
            // 
            this.teTitle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANG_VIENBindingSource, "HocHam", true));
            this.teTitle.Location = new System.Drawing.Point(177, 341);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(100, 20);
            this.teTitle.TabIndex = 8;
            // 
            // tePro
            // 
            this.tePro.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANG_VIENBindingSource, "ChuyenMon", true));
            this.tePro.Location = new System.Drawing.Point(177, 367);
            this.tePro.Name = "tePro";
            this.tePro.Size = new System.Drawing.Size(100, 20);
            this.tePro.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.onCancel);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 473);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(chuyenMonLabel);
            this.Controls.Add(this.tePro);
            this.Controls.Add(hocHamLabel);
            this.Controls.Add(this.teTitle);
            this.Controls.Add(hocViLabel);
            this.Controls.Add(this.teDegree);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.teName);
            this.Controls.Add(maGVLabel);
            this.Controls.Add(this.teId);
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
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDegree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePro.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource gIANG_VIENBindingSource;
        private QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANG_VIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit teId;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teDegree;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.TextEdit tePro;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}