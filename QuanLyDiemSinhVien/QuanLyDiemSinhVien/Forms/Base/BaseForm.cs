using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.Forms.Base
{
    public partial class BaseForm : Form
    {
        public enum FormState
        {
            VIEW,
            ADD,
            EDIT,
        }

        //  Methods
        public virtual void loadWithData(object data)
        {
            //  Override at child class
        }

        //  Button actions
        public virtual void onAdd()
        {
            //  Override at child class
        }

        public virtual void onEdit()
        {
            //  Override at child class
        }

        public virtual void onSave()
        {
            //  Override at child class
        }

        public virtual void onUndo()
        {
            //  Override at child class
        }

        public virtual void onDelete()
        {
            //  Override at child class
        }

        public virtual void onRefresh()
        {
            //  Override at child class
        }

        public virtual void onRegister()
        {

        }
    }
}
