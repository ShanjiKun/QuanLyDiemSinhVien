using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDiemSinhVien.Sql;
using QuanLyDiemSinhVien.Models.ValidCreditClass;
using QuanLyDiemSinhVien.Models.CreditClassDetail;

namespace QuanLyDiemSinhVien.Forms.Student.RegisterCreditClass
{
    public partial class RegisterCreditClassForm : DevExpress.XtraEditors.XtraForm
    {
        public RegisterCreditClassForm()
        {
            InitializeComponent();
        }

        private void RegisterCreditClassForm_Load(object sender, EventArgs e)
        {
            loadData();   
        }

        //  MARK: Setting up
        void setupUI()
        {
            Panel pannel = new Panel();
            pannel.Location = new Point(60, 20);
            pannel.Size = new Size(400, 200);
            pannel.BorderStyle = BorderStyle.FixedSingle;
            pannel.AutoScroll = true;

            Button dynamicButton = new Button();
            dynamicButton.Location = new Point(0, 0);
            dynamicButton.Height = 40;
            dynamicButton.Width = 300;
            dynamicButton.Text = "I am Dynamic Button";
            dynamicButton.Name = "DynamicButton";



            pannel.Controls.Add(dynamicButton);
            this.Controls.Add(pannel);
        }

        List<ValidCreditClassModel> items;
        List<ValidCreditClassModel> itemsSelected = new List<ValidCreditClassModel>();
        void loadData()
        {
            SqlClient.sharedInstance().getValidCreditClass( validCreditClasses => {
                items = validCreditClasses as List<ValidCreditClassModel>;
                loadDataSuccess();
            }, errorMessage => {
                MessageBox.Show("Get Valid Credit Class failure, lỗi: \n\n" + errorMessage);
            });
        }
        
        int CurrentWidth = 1000;
        int currentPanelHeight = 0;
        void loadDataSuccess()
        {
            //  Render Headers
            this.Controls.Add(renderHeader(4, 4));

            //  Show Credit class
            showCreditClassDetail();

            //  Render Headers For Selected
            this.Controls.Add(renderHeader(54, 304, false));

            //  Show Credit class Selected
            showCreditClassSelected();
        }
        void showCreditClassDetail()
        {
            //  Remove all child controls
            currentPanelHeight = 0;
            pnRegister.Controls.Clear();

            //  Handles
            if(items == null)
            {
                MessageBox.Show("LopTC error, lỗi: \n\n null");
                return;
            }

            foreach (ValidCreditClassModel item in items)
            {
                if (item.details == null || item.details.Count == 0)
                {
                    MessageBox.Show("{0} không có CT_LOP_TC", item.creditID.ToString());
                }
                else
                {
                    //  Render Rows
                    pnRegister.Controls.Add(renderRows(item, items.IndexOf(item)));
                }
            }
        }

        void showCreditClassSelected()
        {
            //  Remove all child controls
            currentPanelHeight = 0;
            pnSelected.Controls.Clear();

            //  Handles
            foreach (ValidCreditClassModel item in itemsSelected)
            {
                if (item.details == null || item.details.Count == 0)
                {
                    MessageBox.Show("{0} không có CT_LOP_TC", item.creditID.ToString());
                }
                else
                {
                    //  Render Rows
                    pnSelected.Controls.Add(renderRows(item, items.IndexOf(item), false));
                }
            }
        }

        //  MARK: Renders
        Panel renderHeader(int x, int y)
        {
            return renderHeader(x, y, true);
        }
        Panel renderHeader(int x, int y, bool isRenderRadio)
        {
            //  Define columns
            List<Object> columns = new List<object>();
            Dictionary<string, object> col;

            if (isRenderRadio)
            {
                col = new Dictionary<string, object>();
                col.Add("name", "SelectHeader");
                col.Add("text", "");
                col.Add("width", 50);
                columns.Add(col);
            }

            col = new Dictionary<string, object>();
            col.Add("name", "CreditIDHeader");
            col.Add("text", "MaLTC");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "SubjectIDHeader");
            col.Add("text", "MaMon");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "SubjectNameHeader");
            col.Add("text", "TenMon");
            col.Add("width", 100);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "GroupHeader");
            col.Add("text", "Nhom");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "NumberCreditHeader");
            col.Add("text", "SoTC");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "TeacherHeader");
            col.Add("text", "Giang Vien");
            col.Add("width", 150);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "RoomHeader");
            col.Add("text", "Phong");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "WeakdayHeader");
            col.Add("text", "Thu");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "PeriodHeader");
            col.Add("text", "Buoi");
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", "TimeHeader");
            col.Add("text", "Thoi Gian");
            col.Add("width", 350);
            columns.Add(col);

            //  Panel
            int panelHeight = 44, panelWidth = isRenderRadio ? CurrentWidth : CurrentWidth - 50;

            Panel panel = createPanel(x, y, panelWidth + 2, panelHeight + 2);
            renderColumns(columns, panelHeight, 0, 0, panel);

            return panel;
        }

        Panel renderRows(ValidCreditClassModel item, int index)
        {
            return renderRows(item, index, true);
        }
        Panel renderRows(ValidCreditClassModel item, int index, bool isRenderRadio)
        {
            //  Define columns
            List<Object> columns = new List<object>();
            List<Object> listDetailColumns = new List<object>();
            Dictionary<string, object> col;

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("CreditID{0}", index));
            col.Add("text", item.creditID.ToString());
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("SubjectID{0}", index));
            col.Add("text", item.subjectId);
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("SubjectName{0}", index));
            col.Add("text", item.subjectName);
            col.Add("width", 100);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("Group{0}", index));
            col.Add("text", item.group.ToString());
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("NumberCredit{0}", index));
            col.Add("text", item.numberCredit.ToString());
            col.Add("width", 50);
            columns.Add(col);

            col = new Dictionary<string, object>();
            col.Add("name", string.Format("Teacher{0}", index));
            col.Add("text", item.teacherName);
            col.Add("width", 150);
            columns.Add(col);

            foreach (CreditClassDetailModel detail in item.details)
            {
                List<object> detailColumns = new List<object>();

                col = new Dictionary<string, object>();
                col.Add("name", string.Format("Room{0}", index));
                col.Add("text", detail.MaPh);
                col.Add("width", 50);
                detailColumns.Add(col);

                col = new Dictionary<string, object>();
                col.Add("name", string.Format("Weakday{0}", index));
                col.Add("text", detail.Thu);
                col.Add("width", 50);
                detailColumns.Add(col);

                col = new Dictionary<string, object>();
                col.Add("name", string.Format("Period{0}", index));
                col.Add("text", detail.Buoi);
                col.Add("width", 50);
                detailColumns.Add(col);

                col = new Dictionary<string, object>();
                col.Add("name", string.Format("Time{0}", index));
                col.Add("text", string.Format("{0} - {1}", detail.NgayBatDau, detail.NgayKetThuc));
                col.Add("width", 350);
                detailColumns.Add(col);

                listDetailColumns.Add(detailColumns);
            }

            //  Panel
            int panelHeight = 0, panelWidth = isRenderRadio ? CurrentWidth : CurrentWidth - 49;
            int rowHeight = 44;
            panelHeight += item.details.Count * rowHeight; // 44 per row

            Panel panel = createPanel(0, currentPanelHeight, panelWidth + 1, panelHeight + 2);
            currentPanelHeight += panelHeight;

            int currentX = 0;

            //  Render Radio
            if (isRenderRadio)
            {
                int rX = currentX + 15;
                int rW = 20;
                string rName = string.Format("Radio_{0}", index);
                RadioButton radio = createRadio(rX, 0, panelHeight, rW, rName);
                currentX += 49;
                panel.Controls.Add(radio);
            }

            //  Render Credit Class
            currentX = renderColumns(columns, panelHeight, currentX, 0, panel);

            //  Render details
            int y = 0;
            foreach (List<Object> details in listDetailColumns)
            {
                renderColumns(details, rowHeight, currentX, y, panel);
                y += rowHeight;
            }

            return panel;
        }

        int renderColumns(List<object> columns, int rowHeight, int curX, int curY, Panel panel)
        {
            int currentX = curX;
            foreach (Dictionary<string, object> column in columns)
            {
                int x, y, h, w;
                string text, name;

                x = currentX;
                y = curY;
                h = rowHeight;
                w = (int)column["width"];
                text = column["text"] as string;
                name = column["name"] as string;

                currentX += (int)column["width"];

                Label label = createLabel(x, y, h, w, text, name);
                panel.Controls.Add(label);
            }

            return currentX;
        }

        //  MARK: Actions
        bool isCheck = false;
        void radioButton_OnMouseDown(object sender, MouseEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio != null)
            {
                isCheck = radio.Checked;
            }
        }

        void radioButton_OnMouseUp(object sender, MouseEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio != null)
            {
                radio.Checked = !isCheck;
            }
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio != null)
            {
                if (radio.Checked)
                {
                    try
                    {
                        string indexStr = radio.Name.Split("_"[0])[1];
                        int index = Convert.ToInt32(indexStr);
                        itemsSelected.Add(items[index]);
                        showCreditClassSelected();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add Credit - Cannot get index from radio " + radio.Name + ", desc: \n\n " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        string indexStr = radio.Name.Split("_"[0])[1];
                        int index = Convert.ToInt32(indexStr);
                        itemsSelected.Remove(items[index]);
                        showCreditClassSelected();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Remove Credit - Cannot get index from radio " + radio.Name + ", desc: \n\n " + ex.Message);
                    }
                }
            }
        }

        //  MARK: Helpers
        Panel createPanel(int x, int y, int width, int height)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(width, height);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoScroll = true;
            return panel;
        }

        Button createButton(int x, int y, int h, int w, string text, string name)
        {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Height = h;
            button.Width = w;
            button.Text = text;
            button.Name = name;
            return button;
        }

        Label createLabel(int x, int y, int h, int w, string text, string name)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Height = h;
            label.Width = w;
            label.Text = text;
            label.Name = name;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        RadioButton createRadio(int x, int y, int h, int w, string name)
        {
            RadioButton radio = new RadioButton();
            radio.Location = new Point(x, y);
            radio.Height = h;
            radio.Width = w;
            radio.Name = name;
            radio.TextAlign = ContentAlignment.MiddleCenter;
            radio.MouseDown += new MouseEventHandler(radioButton_OnMouseDown);
            radio.MouseUp += new MouseEventHandler(radioButton_OnMouseUp);
            radio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            return radio;
        }
    }
}