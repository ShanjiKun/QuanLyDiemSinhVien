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

using QuanLyDiemSinhVien.Forms.Science.Student;
using QuanLyDiemSinhVien.Forms.Science.Teacher;
using QuanLyDiemSinhVien.Forms.Science.Subject;
using QuanLyDiemSinhVien.Forms.Science.CreditClasses;

namespace QuanLyDiemSinhVien.Forms.Science
{
    public partial class FormScience : DevExpress.XtraBars.Ribbon.RibbonForm
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
            string userID = UserProfile.sharedInstance().userID;
            string name = UserProfile.sharedInstance().name;
            string role = UserProfile.sharedInstance().role;
            BarBottom.Caption = userID + " - " + name + " - " + role;
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

        //  Selecting Features
        private void onAdd(object sender, ItemClickEventArgs e)
        {

        }

        private void onEdit(object sender, ItemClickEventArgs e)
        {

        }

        private void onSave(object sender, ItemClickEventArgs e)
        {

        }

        private void onUndo(object sender, ItemClickEventArgs e)
        {

        }

        private void onDelete(object sender, ItemClickEventArgs e)
        {

        }

        private void onRefresh(object sender, ItemClickEventArgs e)
        {

        }

        //  MARK: Helpers
        void showForm(Form form)
        {
            Console.WriteLine(form.Name);
            if (isExistForm(form.Name))
            {
                activeForm(form.Name);
            }
            else
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        bool isExistForm(string formName)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName) return true;
            }
            return false;
        }

        void activeForm(string formName)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName)
                {
                    form.Activate();
                    break;
                }
            }
        }
    }
}