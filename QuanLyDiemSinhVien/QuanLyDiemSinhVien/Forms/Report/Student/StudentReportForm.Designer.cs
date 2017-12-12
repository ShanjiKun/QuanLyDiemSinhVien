namespace QuanLyDiemSinhVien.Forms.Report.Student
{
    partial class StudentReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbScience = new System.Windows.Forms.ComboBox();
            this.getSubscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QuanLyDiemSinhVien.QLDSVDataSet();
            this.getSubscriptionsTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.GetSubscriptionsTableAdapter();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sP_GetStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GetStudentTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.SP_GetStudentTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.getSubscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // cbScience
            // 
            this.cbScience.DataSource = this.getSubscriptionsBindingSource;
            this.cbScience.DisplayMember = "Name";
            this.cbScience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScience.FormattingEnabled = true;
            this.cbScience.Location = new System.Drawing.Point(54, 10);
            this.cbScience.Name = "cbScience";
            this.cbScience.Size = new System.Drawing.Size(148, 21);
            this.cbScience.TabIndex = 2;
            this.cbScience.ValueMember = "ScienceID";
            this.cbScience.SelectedValueChanged += new System.EventHandler(this.onCBScienceChanged);
            // 
            // getSubscriptionsBindingSource
            // 
            this.getSubscriptionsBindingSource.DataMember = "GetSubscriptions";
            this.getSubscriptionsBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSubscriptionsTableAdapter
            // 
            this.getSubscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(278, 10);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(152, 21);
            this.cbClass.TabIndex = 3;
            this.cbClass.SelectedValueChanged += new System.EventHandler(this.onCBClassChanged);
            // 
            // crView
            // 
            this.crView.ActiveViewIndex = -1;
            this.crView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crView.Location = new System.Drawing.Point(12, 37);
            this.crView.Name = "crView";
            this.crView.Size = new System.Drawing.Size(627, 425);
            this.crView.TabIndex = 4;
            // 
            // sP_GetStudentBindingSource
            // 
            this.sP_GetStudentBindingSource.DataMember = "SP_GetStudent";
            this.sP_GetStudentBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sP_GetStudentTableAdapter
            // 
            this.sP_GetStudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StudentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 474);
            this.Controls.Add(this.crView);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbScience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentReportForm";
            this.Text = "StudentReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getSubscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbScience;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource getSubscriptionsBindingSource;
        private QLDSVDataSetTableAdapters.GetSubscriptionsTableAdapter getSubscriptionsTableAdapter;
        private System.Windows.Forms.ComboBox cbClass;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crView;
        private System.Windows.Forms.BindingSource sP_GetStudentBindingSource;
        private QLDSVDataSetTableAdapters.SP_GetStudentTableAdapter sP_GetStudentTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}