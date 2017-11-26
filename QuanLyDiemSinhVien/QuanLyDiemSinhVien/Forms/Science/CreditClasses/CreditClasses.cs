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

namespace QuanLyDiemSinhVien.Forms.Science.CreditClasses
{
    public partial class CreditClasses : Form
    {
        public CreditClasses()
        {
            InitializeComponent();
        }

        private void lOP_TCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOP_TCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void CreditClasses_Load(object sender, EventArgs e)
        {
            this.lOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP_TC);
        }
    }
}
