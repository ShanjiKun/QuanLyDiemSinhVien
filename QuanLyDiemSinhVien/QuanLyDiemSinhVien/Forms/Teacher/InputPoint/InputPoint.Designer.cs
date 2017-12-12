namespace QuanLyDiemSinhVien.Forms.Teacher.InputPoint
{
    partial class InputPoint
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
            System.Windows.Forms.Label diemLabel;
            System.Windows.Forms.Label maMonLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cbCredit = new System.Windows.Forms.ComboBox();
            this.qLDSVDataSet = new QuanLyDiemSinhVien.QLDSVDataSet();
            this.sP_GetRegistrationByCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GetRegistrationByCreditTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.SP_GetRegistrationByCreditTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.sP_GetRegistrationByCreditGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.teId = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.sePoint = new DevExpress.XtraEditors.SpinEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.lOPTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOP_TCTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter();
            this.tableAdapterManager1 = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.maMonTextEdit = new DevExpress.XtraEditors.TextEdit();
            maSVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            maMonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetRegistrationByCreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetRegistrationByCreditGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMonTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(52, 414);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(42, 13);
            maSVLabel.TabIndex = 6;
            maSVLabel.Text = "Ma SV:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(47, 443);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 7;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // diemLabel
            // 
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(58, 469);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(34, 13);
            diemLabel.TabIndex = 11;
            diemLabel.Text = "Diem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp tín chỉ:";
            // 
            // cbCredit
            // 
            this.cbCredit.DataSource = this.lOPTCBindingSource;
            this.cbCredit.DisplayMember = "MaLTC";
            this.cbCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCredit.FormattingEnabled = true;
            this.cbCredit.Location = new System.Drawing.Point(78, 10);
            this.cbCredit.Name = "cbCredit";
            this.cbCredit.Size = new System.Drawing.Size(134, 21);
            this.cbCredit.TabIndex = 1;
            this.cbCredit.ValueMember = "MaLTC";
            this.cbCredit.SelectedValueChanged += new System.EventHandler(this.onCBCreditChanged);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_GetRegistrationByCreditBindingSource
            // 
            this.sP_GetRegistrationByCreditBindingSource.DataMember = "SP_GetRegistrationByCredit";
            this.sP_GetRegistrationByCreditBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sP_GetRegistrationByCreditTableAdapter
            // 
            this.sP_GetRegistrationByCreditTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_GetRegistrationByCreditGridControl
            // 
            this.sP_GetRegistrationByCreditGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sP_GetRegistrationByCreditGridControl.DataSource = this.sP_GetRegistrationByCreditBindingSource;
            this.sP_GetRegistrationByCreditGridControl.Location = new System.Drawing.Point(12, 37);
            this.sP_GetRegistrationByCreditGridControl.MainView = this.gridView1;
            this.sP_GetRegistrationByCreditGridControl.Name = "sP_GetRegistrationByCreditGridControl";
            this.sP_GetRegistrationByCreditGridControl.Size = new System.Drawing.Size(570, 315);
            this.sP_GetRegistrationByCreditGridControl.TabIndex = 6;
            this.sP_GetRegistrationByCreditGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_GetRegistrationByCreditGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // teId
            // 
            this.teId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetRegistrationByCreditBindingSource, "MaSV", true));
            this.teId.Location = new System.Drawing.Point(98, 411);
            this.teId.Name = "teId";
            this.teId.Size = new System.Drawing.Size(161, 20);
            this.teId.TabIndex = 7;
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetRegistrationByCreditBindingSource, "HoTen", true));
            this.teName.Location = new System.Drawing.Point(98, 440);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(161, 20);
            this.teName.TabIndex = 8;
            // 
            // sePoint
            // 
            this.sePoint.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_GetRegistrationByCreditBindingSource, "Diem", true));
            this.sePoint.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePoint.Location = new System.Drawing.Point(98, 466);
            this.sePoint.Name = "sePoint";
            this.sePoint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePoint.Size = new System.Drawing.Size(75, 20);
            this.sePoint.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Nhập";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CHUYEN_NGANHTableAdapter = null;
            this.tableAdapterManager1.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager1.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOP_TCTableAdapter = this.lOP_TCTableAdapter;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONTableAdapter = null;
            this.tableAdapterManager1.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager1.PHONG_HOCTableAdapter = null;
            this.tableAdapterManager1.SINH_VIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maMonLabel
            // 
            maMonLabel.AutoSize = true;
            maMonLabel.Location = new System.Drawing.Point(279, 13);
            maMonLabel.Name = "maMonLabel";
            maMonLabel.Size = new System.Drawing.Size(49, 13);
            maMonLabel.TabIndex = 14;
            maMonLabel.Text = "Ma Mon:";
            // 
            // maMonTextEdit
            // 
            this.maMonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPTCBindingSource, "MaMon", true));
            this.maMonTextEdit.Enabled = false;
            this.maMonTextEdit.Location = new System.Drawing.Point(334, 10);
            this.maMonTextEdit.Name = "maMonTextEdit";
            this.maMonTextEdit.Size = new System.Drawing.Size(164, 20);
            this.maMonTextEdit.TabIndex = 15;
            // 
            // InputPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 592);
            this.Controls.Add(maMonLabel);
            this.Controls.Add(this.maMonTextEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(diemLabel);
            this.Controls.Add(this.sePoint);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.teName);
            this.Controls.Add(maSVLabel);
            this.Controls.Add(this.teId);
            this.Controls.Add(this.sP_GetRegistrationByCreditGridControl);
            this.Controls.Add(this.cbCredit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputPoint";
            this.Text = "InputPoint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InputPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetRegistrationByCreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetRegistrationByCreditGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMonTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCredit;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource sP_GetRegistrationByCreditBindingSource;
        private QLDSVDataSetTableAdapters.SP_GetRegistrationByCreditTableAdapter sP_GetRegistrationByCreditTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_GetRegistrationByCreditGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit teId;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.SpinEdit sePoint;
        private System.Windows.Forms.Button btnAdd;
        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource lOPTCBindingSource;
        private QLDSVDataSet_TablesTableAdapters.LOP_TCTableAdapter lOP_TCTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.TextEdit maMonTextEdit;
    }
}