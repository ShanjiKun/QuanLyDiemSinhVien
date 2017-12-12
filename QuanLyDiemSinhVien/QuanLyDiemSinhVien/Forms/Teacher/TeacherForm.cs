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
using QuanLyDiemSinhVien.Forms.Teacher.InputPoint;

namespace QuanLyDiemSinhVien.Forms.Teacher
{
    public partial class TeacherForm : Base.BaseRibbonForm
    {
        public TeacherForm()
        {
            InitializeComponent();
            
            //  Able MdiContainer
            IsMdiContainer = true;
        }

        private void onInputPoint(object sender, ItemClickEventArgs e)
        {
            InputPoint.InputPoint inputPointForm = new InputPoint.InputPoint();
            showForm(inputPointForm);
        }
    }
}