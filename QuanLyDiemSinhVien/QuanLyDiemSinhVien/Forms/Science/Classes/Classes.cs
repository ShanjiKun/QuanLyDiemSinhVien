using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSinhVien.Sql;
namespace QuanLyDiemSinhVien.Forms.Science.Classes
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP);
        }
    }
}
