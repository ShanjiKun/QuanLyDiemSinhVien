namespace QuanLyDiemSinhVien.Forms.Science.CreditClassDetail
{
    partial class CreditClassDetail
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
            this.cT_LOP_TCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_LOP_TCTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.CT_LOP_TCTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.cT_LOP_TCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCreditClasses = new System.Windows.Forms.ComboBox();
            this.lOPTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOP_TCTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.pHONGHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONG_HOCTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.PHONG_HOCTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWeekday = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.dpBegin = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_LOP_TCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_LOP_TCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cT_LOP_TCBindingSource
            // 
            this.cT_LOP_TCBindingSource.DataMember = "CT_LOP_TC";
            this.cT_LOP_TCBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // cT_LOP_TCTableAdapter
            // 
            this.cT_LOP_TCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = this.cT_LOP_TCTableAdapter;
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
            // cT_LOP_TCGridControl
            // 
            this.cT_LOP_TCGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cT_LOP_TCGridControl.DataSource = this.cT_LOP_TCBindingSource;
            this.cT_LOP_TCGridControl.Location = new System.Drawing.Point(12, 12);
            this.cT_LOP_TCGridControl.MainView = this.gridView1;
            this.cT_LOP_TCGridControl.Name = "cT_LOP_TCGridControl";
            this.cT_LOP_TCGridControl.Size = new System.Drawing.Size(722, 220);
            this.cT_LOP_TCGridControl.TabIndex = 1;
            this.cT_LOP_TCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.cT_LOP_TCGridControl.Click += new System.EventHandler(this.onCreditClassDetail);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cT_LOP_TCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã lớp tín chỉ";
            // 
            // cbCreditClasses
            // 
            this.cbCreditClasses.DataSource = this.lOPTCBindingSource;
            this.cbCreditClasses.DisplayMember = "MaLTC";
            this.cbCreditClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreditClasses.FormattingEnabled = true;
            this.cbCreditClasses.Location = new System.Drawing.Point(91, 267);
            this.cbCreditClasses.Name = "cbCreditClasses";
            this.cbCreditClasses.Size = new System.Drawing.Size(121, 21);
            this.cbCreditClasses.TabIndex = 3;
            this.cbCreditClasses.ValueMember = "MaLTC";
            // 
            // lOPTCBindingSource
            // 
            this.lOPTCBindingSource.DataMember = "LOP_TC";
            this.lOPTCBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // lOP_TCTableAdapter
            // 
            this.lOP_TCTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phòng";
            // 
            // cbRoom
            // 
            this.cbRoom.DataSource = this.pHONGHOCBindingSource;
            this.cbRoom.DisplayMember = "MaPhong";
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(91, 299);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 21);
            this.cbRoom.TabIndex = 5;
            this.cbRoom.ValueMember = "MaPhong";
            // 
            // pHONGHOCBindingSource
            // 
            this.pHONGHOCBindingSource.DataMember = "PHONG_HOC";
            this.pHONGHOCBindingSource.DataSource = this.qLDSVDataSet_Tables;
            // 
            // pHONG_HOCTableAdapter
            // 
            this.pHONG_HOCTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thứ";
            // 
            // cbWeekday
            // 
            this.cbWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeekday.FormattingEnabled = true;
            this.cbWeekday.Location = new System.Drawing.Point(92, 333);
            this.cbWeekday.Name = "cbWeekday";
            this.cbWeekday.Size = new System.Drawing.Size(121, 21);
            this.cbWeekday.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buổi";
            // 
            // cbPeriod
            // 
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(91, 365);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cbPeriod.TabIndex = 9;
            // 
            // dpBegin
            // 
            this.dpBegin.Location = new System.Drawing.Point(92, 402);
            this.dpBegin.Name = "dpBegin";
            this.dpBegin.Size = new System.Drawing.Size(200, 20);
            this.dpBegin.TabIndex = 10;
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(92, 429);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(200, 20);
            this.dpEnd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày kết thúc";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // CreditClassDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 496);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpBegin);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWeekday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCreditClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cT_LOP_TCGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditClassDetail";
            this.Text = "CreditClassDetail";
            this.Load += new System.EventHandler(this.CreditClassDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_LOP_TCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_LOP_TCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource cT_LOP_TCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.CT_LOP_TCTableAdapter cT_LOP_TCTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cT_LOP_TCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCreditClasses;
        private System.Windows.Forms.BindingSource lOPTCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter lOP_TCTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.BindingSource pHONGHOCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.PHONG_HOCTableAdapter pHONG_HOCTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWeekday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.DateTimePicker dpBegin;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
    }
}