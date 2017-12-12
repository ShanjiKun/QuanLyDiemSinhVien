namespace QuanLyDiemSinhVien.Forms.Report.Exam
{
    partial class ExamReportForm
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
            this.cbCreditClass = new System.Windows.Forms.ComboBox();
            this.crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.getSubscriptionsTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.GetSubscriptionsTableAdapter();
            this.sP_StudentExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_StudentExamTableAdapter = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.SP_StudentExamTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.getSubscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_StudentExamBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp tín chỉ:";
            // 
            // cbScience
            // 
            this.cbScience.DataSource = this.getSubscriptionsBindingSource;
            this.cbScience.DisplayMember = "Name";
            this.cbScience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScience.FormattingEnabled = true;
            this.cbScience.Location = new System.Drawing.Point(54, 10);
            this.cbScience.Name = "cbScience";
            this.cbScience.Size = new System.Drawing.Size(180, 21);
            this.cbScience.TabIndex = 2;
            this.cbScience.ValueMember = "ScienceID";
            this.cbScience.SelectedValueChanged += new System.EventHandler(this.onScienceChanged);
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
            // cbCreditClass
            // 
            this.cbCreditClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreditClass.FormattingEnabled = true;
            this.cbCreditClass.Location = new System.Drawing.Point(362, 10);
            this.cbCreditClass.Name = "cbCreditClass";
            this.cbCreditClass.Size = new System.Drawing.Size(154, 21);
            this.cbCreditClass.TabIndex = 3;
            this.cbCreditClass.SelectedValueChanged += new System.EventHandler(this.onCreditClassChanged);
            // 
            // crView
            // 
            this.crView.ActiveViewIndex = -1;
            this.crView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crView.Location = new System.Drawing.Point(13, 41);
            this.crView.Name = "crView";
            this.crView.Size = new System.Drawing.Size(579, 431);
            this.crView.TabIndex = 4;
            // 
            // getSubscriptionsTableAdapter
            // 
            this.getSubscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // sP_StudentExamBindingSource
            // 
            this.sP_StudentExamBindingSource.DataMember = "SP_StudentExam";
            this.sP_StudentExamBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sP_StudentExamTableAdapter
            // 
            this.sP_StudentExamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ExamReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 484);
            this.Controls.Add(this.crView);
            this.Controls.Add(this.cbCreditClass);
            this.Controls.Add(this.cbScience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamReportForm";
            this.Text = "ExamReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getSubscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_StudentExamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbScience;
        private System.Windows.Forms.ComboBox cbCreditClass;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crView;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource getSubscriptionsBindingSource;
        private QLDSVDataSetTableAdapters.GetSubscriptionsTableAdapter getSubscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource sP_StudentExamBindingSource;
        private QLDSVDataSetTableAdapters.SP_StudentExamTableAdapter sP_StudentExamTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}