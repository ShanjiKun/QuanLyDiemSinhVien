namespace QuanLyDiemSinhVien.Forms.Science.Subject
{
    partial class Subject
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
            System.Windows.Forms.Label maMonLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label soTLTLabel;
            System.Windows.Forms.Label soTTHLabel;
            System.Windows.Forms.Label soTCLabel;
            this.qLDSVDataSet_Tables = new QuanLyDiemSinhVien.QLDSVDataSet_Tables();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.MONTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager();
            this.mONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.teSubjectID = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.seTheory = new DevExpress.XtraEditors.SpinEdit();
            this.sePractise = new DevExpress.XtraEditors.SpinEdit();
            this.seCredit = new DevExpress.XtraEditors.SpinEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            maMonLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            soTLTLabel = new System.Windows.Forms.Label();
            soTTHLabel = new System.Windows.Forms.Label();
            soTCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTheory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePractise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCredit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maMonLabel
            // 
            maMonLabel.AutoSize = true;
            maMonLabel.Location = new System.Drawing.Point(119, 274);
            maMonLabel.Name = "maMonLabel";
            maMonLabel.Size = new System.Drawing.Size(49, 13);
            maMonLabel.TabIndex = 1;
            maMonLabel.Text = "Mã Môn:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(116, 300);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(52, 13);
            tenLabel.TabIndex = 3;
            tenLabel.Text = "Tên môn:";
            // 
            // soTLTLabel
            // 
            soTLTLabel.AutoSize = true;
            soTLTLabel.Location = new System.Drawing.Point(86, 326);
            soTLTLabel.Name = "soTLTLabel";
            soTLTLabel.Size = new System.Drawing.Size(82, 13);
            soTLTLabel.TabIndex = 5;
            soTLTLabel.Text = "Số tiết lý thuyết:";
            // 
            // soTTHLabel
            // 
            soTTHLabel.AutoSize = true;
            soTTHLabel.Location = new System.Drawing.Point(77, 352);
            soTTHLabel.Name = "soTTHLabel";
            soTTHLabel.Size = new System.Drawing.Size(91, 13);
            soTTHLabel.TabIndex = 7;
            soTTHLabel.Text = "Số tiết thực hành:";
            // 
            // soTCLabel
            // 
            soTCLabel.AutoSize = true;
            soTCLabel.Location = new System.Drawing.Point(112, 378);
            soTCLabel.Name = "soTCLabel";
            soTCLabel.Size = new System.Drawing.Size(56, 13);
            soTCLabel.TabIndex = 9;
            soTCLabel.Text = "Số tín chỉ:";
            // 
            // qLDSVDataSet_Tables
            // 
            this.qLDSVDataSet_Tables.DataSetName = "QLDSVDataSet_Tables";
            this.qLDSVDataSet_Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_LOP_TCTableAdapter = null;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP_TCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = this.mONTableAdapter;
            this.tableAdapterManager.NIEN_KHOATableAdapter = null;
            this.tableAdapterManager.PHONG_HOCTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSet_TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONGridControl
            // 
            this.mONGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mONGridControl.DataSource = this.mONBindingSource;
            this.mONGridControl.Location = new System.Drawing.Point(1, 2);
            this.mONGridControl.MainView = this.gridView1;
            this.mONGridControl.Name = "mONGridControl";
            this.mONGridControl.Size = new System.Drawing.Size(851, 220);
            this.mONGridControl.TabIndex = 1;
            this.mONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.mONGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // teSubjectID
            // 
            this.teSubjectID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONBindingSource, "MaMon", true));
            this.teSubjectID.Location = new System.Drawing.Point(174, 271);
            this.teSubjectID.Name = "teSubjectID";
            this.teSubjectID.Size = new System.Drawing.Size(130, 20);
            this.teSubjectID.TabIndex = 2;
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONBindingSource, "Ten", true));
            this.teName.Location = new System.Drawing.Point(174, 297);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(130, 20);
            this.teName.TabIndex = 4;
            // 
            // seTheory
            // 
            this.seTheory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONBindingSource, "SoTLT", true));
            this.seTheory.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTheory.Location = new System.Drawing.Point(174, 323);
            this.seTheory.Name = "seTheory";
            this.seTheory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTheory.Size = new System.Drawing.Size(130, 20);
            this.seTheory.TabIndex = 6;
            // 
            // sePractise
            // 
            this.sePractise.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONBindingSource, "SoTTH", true));
            this.sePractise.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePractise.Location = new System.Drawing.Point(174, 349);
            this.sePractise.Name = "sePractise";
            this.sePractise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePractise.Size = new System.Drawing.Size(130, 20);
            this.sePractise.TabIndex = 8;
            // 
            // seCredit
            // 
            this.seCredit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONBindingSource, "SoTC", true));
            this.seCredit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCredit.Location = new System.Drawing.Point(174, 375);
            this.seCredit.Name = "seCredit";
            this.seCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCredit.Size = new System.Drawing.Size(130, 20);
            this.seCredit.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.onCancel);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 471);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(soTCLabel);
            this.Controls.Add(this.seCredit);
            this.Controls.Add(soTTHLabel);
            this.Controls.Add(this.sePractise);
            this.Controls.Add(soTLTLabel);
            this.Controls.Add(this.seTheory);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.teName);
            this.Controls.Add(maMonLabel);
            this.Controls.Add(this.teSubjectID);
            this.Controls.Add(this.mONGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTheory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePractise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCredit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet_Tables qLDSVDataSet_Tables;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private QLDSVDataSet_TablesTableAdapters.MONTableAdapter mONTableAdapter;
        private QLDSVDataSet_TablesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit teSubjectID;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.SpinEdit seTheory;
        private DevExpress.XtraEditors.SpinEdit sePractise;
        private DevExpress.XtraEditors.SpinEdit seCredit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}