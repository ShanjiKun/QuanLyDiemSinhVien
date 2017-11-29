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
            //  Handling Adapters
            handleAdapters();

            //  Setting up comboboxes
            setUpComboboxes();
        }

        //  MARK: Setting up
        void handleAdapters()
        {
            this.gIANG_VIENTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.gIANG_VIENTableAdapter.Fill(this.qLDSVDataSet_Tables.GIANG_VIEN);

            this.nIEN_KHOATableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.nIEN_KHOATableAdapter.Fill(this.qLDSVDataSet_Tables.NIEN_KHOA);

            this.mONTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.mONTableAdapter.Fill(this.qLDSVDataSet_Tables.MON);

            this.lOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP_TC);
        }

        void setUpComboboxes()
        {
            //  Combox term
            var items = new[] {
                new { Text = "1", Value = 1},
                new { Text = "2", Value = 2},
                new { Text = "3", Value = 3}
            };

            cbTerm.DisplayMember = "Text";
            cbTerm.ValueMember = "Value";
            cbTerm.DataSource = items;
        }
    }
}
