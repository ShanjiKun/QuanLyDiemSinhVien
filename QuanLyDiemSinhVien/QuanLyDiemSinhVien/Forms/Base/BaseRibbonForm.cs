using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyDiemSinhVien.Forms.Base
{
    public partial class BaseRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public enum BarButtonType
        {
            Add,
            Edit,
            Save,
            Undo,
            Delete,
            Refresh
        }

        public enum NavigationForm
        {
            CreditClassDetail
        }

        //  Methods
        public virtual void navigateToForm(NavigationForm type, object data)
        {
            //  Override at child class
        }

        public virtual void enableButtons(List<BarButtonType> buttonTypes)
        {
            //  Override at child class
        }

        public virtual void disableButtons()
        {
            //  Override at child class
        }

        //  MARK: Helpers
        public void showForm(Form form)
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
