namespace QuanLyDiemSinhVien.Forms.Science.CreditClasses
{
    partial class CreditClasses
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
            this.lOP_TCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOP_TCTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.gvCreditClass = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.MONTableAdapter();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIEN_KHOATableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.NIEN_KHOATableAdapter();
            this.gIANG_VIENTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.lbStMin = new System.Windows.Forms.Label();
            this.txMinSt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpOpen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpClose = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dpExam = new System.Windows.Forms.DateTimePicker();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
            this.panelAdding.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOP_TCBindingSource
            // 
            this.lOP_TCBindingSource.DataMember = "LOP_TC";
            this.lOP_TCBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // lOP_TCTableAdapter
            // 
            this.lOP_TCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TCTableAdapter = this.lOP_TCTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager.PHONG_HOCTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gvCreditClass
            // 
            this.gvCreditClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCreditClass.DataSource = this.lOP_TCBindingSource;
            this.gvCreditClass.Location = new System.Drawing.Point(1, 2);
            this.gvCreditClass.MainView = this.gridView1;
            this.gvCreditClass.Name = "gvCreditClass";
            this.gvCreditClass.Size = new System.Drawing.Size(818, 220);
            this.gvCreditClass.TabIndex = 1;
            this.gvCreditClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvCreditClass.Click += new System.EventHandler(this.onCreditClass);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvCreditClass;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANG_VIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIEN_KHOA";
            this.nIENKHOABindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // nIEN_KHOATableAdapter
            // 
            this.nIEN_KHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANG_VIENTableAdapter
            // 
            this.gIANG_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.mONBindingSource;
            this.cbSubject.DisplayMember = "MaMon";
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(114, 9);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(279, 21);
            this.cbSubject.TabIndex = 2;
            this.cbSubject.ValueMember = "MaMon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhóm";
            // 
            // txGroup
            // 
            this.txGroup.Location = new System.Drawing.Point(114, 39);
            this.txGroup.Name = "txGroup";
            this.txGroup.Size = new System.Drawing.Size(42, 20);
            this.txGroup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kỳ";
            // 
            // cbTerm
            // 
            this.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(115, 68);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(41, 21);
            this.cbTerm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Niên khóa";
            // 
            // cbYear
            // 
            this.cbYear.DataSource = this.nIENKHOABindingSource;
            this.cbYear.DisplayMember = "MaNK";
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(115, 97);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(81, 21);
            this.cbYear.TabIndex = 9;
            this.cbYear.ValueMember = "MaNK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giảng viên";
            // 
            // cbTeacher
            // 
            this.cbTeacher.DataSource = this.gIANGVIENBindingSource;
            this.cbTeacher.DisplayMember = "MaGV";
            this.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(115, 131);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(278, 21);
            this.cbTeacher.TabIndex = 11;
            this.cbTeacher.ValueMember = "MaGV";
            // 
            // lbStMin
            // 
            this.lbStMin.AutoSize = true;
            this.lbStMin.Location = new System.Drawing.Point(17, 164);
            this.lbStMin.Name = "lbStMin";
            this.lbStMin.Size = new System.Drawing.Size(91, 13);
            this.lbStMin.TabIndex = 12;
            this.lbStMin.Text = "Sinh viên tối thiểu";
            // 
            // txMinSt
            // 
            this.txMinSt.Location = new System.Drawing.Point(114, 161);
            this.txMinSt.Name = "txMinSt";
            this.txMinSt.Size = new System.Drawing.Size(42, 20);
            this.txMinSt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày mở ĐK";
            // 
            // dpOpen
            // 
            this.dpOpen.Location = new System.Drawing.Point(115, 189);
            this.dpOpen.Name = "dpOpen";
            this.dpOpen.Size = new System.Drawing.Size(200, 20);
            this.dpOpen.TabIndex = 15;
            this.dpOpen.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày đóng ĐK";
            // 
            // dpClose
            // 
            this.dpClose.Location = new System.Drawing.Point(115, 217);
            this.dpClose.Name = "dpClose";
            this.dpClose.Size = new System.Drawing.Size(200, 20);
            this.dpClose.TabIndex = 17;
            this.dpClose.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày thi";
            // 
            // dpExam
            // 
            this.dpExam.Location = new System.Drawing.Point(115, 245);
            this.dpExam.Name = "dpExam";
            this.dpExam.Size = new System.Drawing.Size(200, 20);
            this.dpExam.TabIndex = 19;
            this.dpExam.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
            // 
            // panelAdding
            // 
            this.panelAdding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdding.Controls.Add(this.btnAddDetail);
            this.panelAdding.Controls.Add(this.btnAdd);
            this.panelAdding.Controls.Add(this.dpExam);
            this.panelAdding.Controls.Add(this.label8);
            this.panelAdding.Controls.Add(this.dpClose);
            this.panelAdding.Controls.Add(this.label7);
            this.panelAdding.Controls.Add(this.dpOpen);
            this.panelAdding.Controls.Add(this.label6);
            this.panelAdding.Controls.Add(this.txMinSt);
            this.panelAdding.Controls.Add(this.lbStMin);
            this.panelAdding.Controls.Add(this.cbTeacher);
            this.panelAdding.Controls.Add(this.label5);
            this.panelAdding.Controls.Add(this.cbYear);
            this.panelAdding.Controls.Add(this.label4);
            this.panelAdding.Controls.Add(this.cbTerm);
            this.panelAdding.Controls.Add(this.label3);
            this.panelAdding.Controls.Add(this.txGroup);
            this.panelAdding.Controls.Add(this.label2);
            this.panelAdding.Controls.Add(this.label1);
            this.panelAdding.Controls.Add(this.cbSubject);
            this.panelAdding.Location = new System.Drawing.Point(12, 228);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(797, 310);
            this.panelAdding.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(115, 273);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(121, 23);
            this.btnAddDetail.TabIndex = 21;
            this.btnAddDetail.Text = "Thêm chi tiết >>";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.onAddDetail);
            // 
            // CreditClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 550);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.gvCreditClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditClasses";
            this.Text = "CreditClasses";
            this.Load += new System.EventHandler(this.CreditClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource lOP_TCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter lOP_TCTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gvCreditClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private QLDSVDataSet_TablesTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
        private QLDSVDataSet_TablesTableAdapters.NIEN_KHOATableAdapter nIEN_KHOATableAdapter;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label lbStMin;
        private System.Windows.Forms.TextBox txMinSt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpExam;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddDetail;
    }
}