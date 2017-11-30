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
            this.lOP_TCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.MONTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.dpExam = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dpClose = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpOpen = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbStMin = new System.Windows.Forms.Label();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nIEN_KHOATableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.NIEN_KHOATableAdapter();
            this.gIANG_VIENTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.panelAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
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
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOP_TCGridControl
            // 
            this.lOP_TCGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lOP_TCGridControl.DataSource = this.lOP_TCBindingSource;
            this.lOP_TCGridControl.Location = new System.Drawing.Point(1, 2);
            this.lOP_TCGridControl.MainView = this.gridView1;
            this.lOP_TCGridControl.Name = "lOP_TCGridControl";
            this.lOP_TCGridControl.Size = new System.Drawing.Size(818, 220);
            this.lOP_TCGridControl.TabIndex = 1;
            this.lOP_TCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.lOP_TCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.mONBindingSource;
            this.cbSubject.DisplayMember = "Ten";
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(114, 9);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(279, 21);
            this.cbSubject.TabIndex = 2;
            this.cbSubject.ValueMember = "MaMon";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn";
            // 
            // panelAdding
            // 
            this.panelAdding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdding.Controls.Add(this.dpExam);
            this.panelAdding.Controls.Add(this.label8);
            this.panelAdding.Controls.Add(this.dpClose);
            this.panelAdding.Controls.Add(this.label7);
            this.panelAdding.Controls.Add(this.dpOpen);
            this.panelAdding.Controls.Add(this.label6);
            this.panelAdding.Controls.Add(this.textBox2);
            this.panelAdding.Controls.Add(this.lbStMin);
            this.panelAdding.Controls.Add(this.cbTeacher);
            this.panelAdding.Controls.Add(this.label5);
            this.panelAdding.Controls.Add(this.comboBox1);
            this.panelAdding.Controls.Add(this.label4);
            this.panelAdding.Controls.Add(this.cbTerm);
            this.panelAdding.Controls.Add(this.label3);
            this.panelAdding.Controls.Add(this.textBox1);
            this.panelAdding.Controls.Add(this.label2);
            this.panelAdding.Controls.Add(this.label1);
            this.panelAdding.Controls.Add(this.cbSubject);
            this.panelAdding.Location = new System.Drawing.Point(12, 228);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(797, 310);
            this.panelAdding.TabIndex = 5;
            // 
            // dpExam
            // 
            this.dpExam.Location = new System.Drawing.Point(115, 245);
            this.dpExam.Name = "dpExam";
            this.dpExam.Size = new System.Drawing.Size(200, 20);
            this.dpExam.TabIndex = 19;
            this.dpExam.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
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
            // dpClose
            // 
            this.dpClose.Location = new System.Drawing.Point(115, 217);
            this.dpClose.Name = "dpClose";
            this.dpClose.Size = new System.Drawing.Size(200, 20);
            this.dpClose.TabIndex = 17;
            this.dpClose.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
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
            // dpOpen
            // 
            this.dpOpen.Location = new System.Drawing.Point(115, 189);
            this.dpOpen.Name = "dpOpen";
            this.dpOpen.Size = new System.Drawing.Size(200, 20);
            this.dpOpen.TabIndex = 15;
            this.dpOpen.Value = new System.DateTime(2017, 11, 30, 4, 49, 9, 0);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 13;
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
            // cbTeacher
            // 
            this.cbTeacher.DataSource = this.gIANGVIENBindingSource;
            this.cbTeacher.DisplayMember = "HoTen";
            this.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(115, 131);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(278, 21);
            this.cbTeacher.TabIndex = 11;
            this.cbTeacher.ValueMember = "MaGV";
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANG_VIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Học kỳ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nIENKHOABindingSource;
            this.comboBox1.DisplayMember = "Ten";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "MaNK";
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIEN_KHOA";
            this.nIENKHOABindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học kỳ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kỳ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 5;
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
            // nIEN_KHOATableAdapter
            // 
            this.nIEN_KHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANG_VIENTableAdapter
            // 
            this.gIANG_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // CreditClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 550);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.lOP_TCGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditClasses";
            this.Text = "CreditClasses";
            this.Load += new System.EventHandler(this.CreditClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP_TCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource lOP_TCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter lOP_TCTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOP_TCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private QLDSVDataSet_TablesTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
        private QLDSVDataSet_TablesTableAdapters.NIEN_KHOATableAdapter nIEN_KHOATableAdapter;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSVDataSet_TablesTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbStMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpOpen;
        private System.Windows.Forms.DateTimePicker dpClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpExam;
        private System.Windows.Forms.Label label8;
    }
}