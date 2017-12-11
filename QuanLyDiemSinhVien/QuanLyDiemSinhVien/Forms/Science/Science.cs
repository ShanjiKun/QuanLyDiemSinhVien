using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyDiemSinhVien.Forms.Science.Classes;
using QuanLyDiemSinhVien.Models.User;

using QuanLyDiemSinhVien.Forms.Base;
using QuanLyDiemSinhVien.Forms.Science.Student;
using QuanLyDiemSinhVien.Forms.Science.Teacher;
using QuanLyDiemSinhVien.Forms.Science.Subject;
using QuanLyDiemSinhVien.Forms.Science.CreditClasses;
using QuanLyDiemSinhVien.Forms.Science.CreditClassDetail;

namespace QuanLyDiemSinhVien.Forms.Science
{
    public partial class FormScience : BaseRibbonForm
    {
        public FormScience()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //  Enable MdiContainer to Child forms set MdiPrent 
            IsMdiContainer = true;

            //  Show user information
            string userID = " Mã: " + UserProfile.sharedInstance().userID;
            string name = " Tên: " + UserProfile.sharedInstance().name;
            string role = " Nhóm: " + UserProfile.sharedInstance().role;
            string science = " Khoa: " + Sql.SqlClient.sharedInstance().scienceID;
            BarBottom.Caption = userID + " - " + name + " - " + role + " - " + science;

            //  Disabal buttons
            disableButtons();
        }

        //  MARK: Public methods
        public override void navigateToForm(NavigationForm type, object data)
        {
            switch (type)
            {
                case NavigationForm.CreditClassDetail:
                    {
                        showCreditClassDetail(data);
                        break;
                    }
                default:
                    break;
            }
        }

        public override void disableButtons()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnDelete.Enabled = false;
            btnRefresh.Enabled = false;
        }

        public override void enableButtons(List<BarButtonType> buttonTypes)
        {
            foreach (BarButtonType btnType in buttonTypes)
            {
                switch(btnType)
                {
                    case BarButtonType.Add:
                        {
                            btnAdd.Enabled = true;
                        }
                        break;
                    case BarButtonType.Edit:
                        {
                            btnEdit.Enabled = true;
                        }
                        break;
                    case BarButtonType.Save:
                        {
                            btnSave.Enabled = true;
                        }
                        break;
                    case BarButtonType.Undo:
                        {
                            btnUndo.Enabled = true;
                        }
                        break;
                    case BarButtonType.Delete:
                        {
                            btnDelete.Enabled = true;
                        }
                        break;
                    case BarButtonType.Refresh:
                        {
                            btnRefresh.Enabled = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        //  MARK: Private method
        //  Show credit class detail form
        void showCreditClassDetail(object data)
        {
            showCreditClassDetail();
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.loadWithData(data);
            }
        }

        void showCreditClassDetail()
        {
            CreditClassDetail.CreditClassDetail creditClassDetail = new CreditClassDetail.CreditClassDetail();
            showForm(creditClassDetail);
        }

        //  MARK: Actions
        //  Selecting Forms
        private void onClasses(object sender, ItemClickEventArgs e)
        {
            Classes.Classes classes = new Classes.Classes();
            showForm(classes);
        }

        private void onStudent(object sender, ItemClickEventArgs e)
        {
            Student.Student student = new Student.Student();
            showForm(student);
        }

        private void onTeacher(object sender, ItemClickEventArgs e)
        {
            Teacher.Teacher teacher = new Teacher.Teacher();
            showForm(teacher);
        }

        private void onSubject(object sender, ItemClickEventArgs e)
        {
            Subject.Subject subject = new Subject.Subject();
            showForm(subject);
        }

        private void onCreditClasses(object sender, ItemClickEventArgs e)
        {
            CreditClasses.CreditClasses creditClasses = new CreditClasses.CreditClasses();
            showForm(creditClasses);
        }

        private void onCreditClassDetail(object sender, ItemClickEventArgs e)
        {
            showCreditClassDetail();
        }

        //  Selecting Features
        private void onAdd(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onAdd();
            }
        }

        private void onEdit(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onEdit();
            }
        }

        private void onSave(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onSave();
            }
        }

        private void onUndo(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onUndo();
            }
        }

        private void onDelete(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onDelete();
            }
        }

        private void onRefresh(object sender, ItemClickEventArgs e)
        {
            BaseForm baseForm = this.ActiveMdiChild as BaseForm;
            if (baseForm != null)
            {
                baseForm.onRefresh();
            }
        }
    }
}