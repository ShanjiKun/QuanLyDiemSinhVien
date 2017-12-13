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
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label phaiLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label khoaHocLabel;
            System.Windows.Forms.Label maCNLabel;
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.LOPTableAdapter();
            this.teId = new DevExpress.XtraEditors.TextEdit();
            this.sP_GetStudentByClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QuanLyDiemSinhVien.QLDSVDataSet();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teSex = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.dpBirthtday = new DevExpress.XtraEditors.DateEdit();
            this.seYear = new DevExpress.XtraEditors.SpinEdit();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYEN_NGANHTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.CHUYEN_NGANHTableAdapter();
            this.teMajor = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.sP_GetStudentByClassTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.SP_GetStudentByClassTableAdapter();
            this.tableAdapterManager1 = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.sP_GetStudentByClassGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            maSVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            khoaHocLabel = new System.Windows.Forms.Label();
            maCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentByClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpBirthtday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpBirthtday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMajor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentByClassGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(31, 276);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(42, 13);
            maSVLabel.TabIndex = 3;
            maSVLabel.Text = "Ma SV:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(27, 305);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 5;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // phaiLabel
            // 
            phaiLabel.AutoSize = true;
            phaiLabel.Location = new System.Drawing.Point(42, 331);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(31, 13);
            phaiLabel.TabIndex = 7;
            phaiLabel.Text = "Phai:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(29, 359);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 9;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(14, 385);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(59, 13);
            ngaySinhLabel.TabIndex = 11;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // khoaHocLabel
            // 
            khoaHocLabel.AutoSize = true;
            khoaHocLabel.Location = new System.Drawing.Point(15, 412);
            khoaHocLabel.Name = "khoaHocLabel";
            khoaHocLabel.Size = new System.Drawing.Size(58, 13);
            khoaHocLabel.TabIndex = 13;
            khoaHocLabel.Text = "Khoa Hoc:";
            // 
            // maCNLabel
            // 
            maCNLabel.AutoSize = true;
            maCNLabel.Location = new System.Drawing.Point(31, 441);
            maCNLabel.Name = "maCNLabel";
            maCNLabel.Size = new System.Drawing.Size(43, 13);
            maCNLabel.TabIndex = 15;
            maCNLabel.Text = "Ma CN:";
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUYEN_NGANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager.PHONG_HOCTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp:";
            // 
            // cbClass
            // 
            this.cbClass.DataSource = this.lOPBindingSource;
            this.cbClass.DisplayMember = "Ten";
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(47, 10);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(174, 21);
            this.cbClass.TabIndex = 3;
            this.cbClass.ValueMember = "MaLop";
            this.cbClass.SelectedValueChanged += new System.EventHandler(this.onCBClassChanged);
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
            // teId
            // 
            this.teId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "MaSV", true));
            this.teId.Location = new System.Drawing.Point(79, 273);
            this.teId.Name = "teId";
            this.teId.Size = new System.Drawing.Size(142, 20);
            this.teId.TabIndex = 4;
            // 
            // sP_GetStudentByClassBindingSource
            // 
            this.sP_GetStudentByClassBindingSource.DataMember = "SP_GetStudentByClass";
            this.sP_GetStudentByClassBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "HoTen", true));
            this.teName.Location = new System.Drawing.Point(79, 302);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(216, 20);
            this.teName.TabIndex = 6;
            // 
            // teSex
            // 
            this.teSex.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "Phai", true));
            this.teSex.Location = new System.Drawing.Point(79, 330);
            this.teSex.Name = "teSex";
            this.teSex.Size = new System.Drawing.Size(77, 20);
            this.teSex.TabIndex = 8;
            // 
            // teAddress
            // 
            this.teAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "DiaChi", true));
            this.teAddress.Location = new System.Drawing.Point(79, 356);
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(216, 20);
            this.teAddress.TabIndex = 10;
            // 
            // dpBirthtday
            // 
            this.dpBirthtday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "NgaySinh", true));
            this.dpBirthtday.EditValue = null;
            this.dpBirthtday.Location = new System.Drawing.Point(79, 382);
            this.dpBirthtday.Name = "dpBirthtday";
            this.dpBirthtday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpBirthtday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpBirthtday.Size = new System.Drawing.Size(122, 20);
            this.dpBirthtday.TabIndex = 12;
            // 
            // seYear
            // 
            this.seYear.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "KhoaHoc", true));
            this.seYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seYear.Location = new System.Drawing.Point(79, 409);
            this.seYear.Name = "seYear";
            this.seYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seYear.Size = new System.Drawing.Size(122, 20);
            this.seYear.TabIndex = 14;
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataMember = "CHUYEN_NGANH";
            this.cHUYENNGANHBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // cHUYEN_NGANHTableAdapter
            // 
            this.cHUYEN_NGANHTableAdapter.ClearBeforeFill = true;
            // 
            // teMajor
            // 
            this.teMajor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetStudentByClassBindingSource, "MaCN", true));
            this.teMajor.Location = new System.Drawing.Point(80, 438);
            this.teMajor.Name = "teMajor";
            this.teMajor.Size = new System.Drawing.Size(100, 20);
            this.teMajor.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.onCancel);
            // 
            // cbMajor
            // 
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(80, 438);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(121, 21);
            this.cbMajor.TabIndex = 19;
            // 
            // sP_GetStudentByClassTableAdapter
            // 
            this.sP_GetStudentByClassTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_GetStudentByClassGridControl
            // 
            this.sP_GetStudentByClassGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sP_GetStudentByClassGridControl.DataSource = this.sP_GetStudentByClassBindingSource;
            this.sP_GetStudentByClassGridControl.Location = new System.Drawing.Point(1, 37);
            this.sP_GetStudentByClassGridControl.MainView = this.gridView1;
            this.sP_GetStudentByClassGridControl.Name = "sP_GetStudentByClassGridControl";
            this.sP_GetStudentByClassGridControl.Size = new System.Drawing.Size(899, 220);
            this.sP_GetStudentByClassGridControl.TabIndex = 20;
            this.sP_GetStudentByClassGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_GetStudentByClassGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 543);
            this.Controls.Add(this.sP_GetStudentByClassGridControl);
            this.Controls.Add(this.cbMajor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(maCNLabel);
            this.Controls.Add(this.teMajor);
            this.Controls.Add(khoaHocLabel);
            this.Controls.Add(this.seYear);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.dpBirthtday);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(phaiLabel);
            this.Controls.Add(this.teSex);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.teName);
            this.Controls.Add(maSVLabel);
            this.Controls.Add(this.teId);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentByClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpBirthtday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpBirthtday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMajor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentByClassGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.TextEdit teId;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teSex;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.DateEdit dpBirthtday;
        private DevExpress.XtraEditors.SpinEdit seYear;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private QLDSVDataSet_TablesTableAdapters.CHUYEN_NGANHTableAdapter cHUYEN_NGANHTableAdapter;
        private DevExpress.XtraEditors.TextEdit teMajor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbMajor;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource sP_GetStudentByClassBindingSource;
        private QLDSVDataSetTableAdapters.SP_GetStudentByClassTableAdapter sP_GetStudentByClassTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl sP_GetStudentByClassGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}