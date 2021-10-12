using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiOilCollect
{
    public partial class DataAddForm : Form
    {
        private Screen _screen = null;
        public DataAddForm(Screen screen)
        {
            _screen = screen;
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;           
            AddNewRowToGrid("配置条数","1");
            AddNewRowToGrid("起始数据地址","1");

        }

        private static DataAddForm _dataAddForm = null;
        public static DataAddForm GetSigForm(Screen screen)
        {
            if (_dataAddForm == null)
            {
                _dataAddForm = new DataAddForm(screen);
            }
            return _dataAddForm;
        }

        public void AddNewRowToGrid(string str1, string str2)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
            textboxcell.Value = str1;
            row1.Cells.Add(textboxcell);
            DataGridViewTextBoxCell textboxcel2 = new DataGridViewTextBoxCell();
            textboxcel2.Value = str2;
            row1.Cells.Add(textboxcel2);
            dataGridView1.Rows.Add(row1);
        }

        private void DataAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataAddForm = null;
        }

        private void DataAddForm_Shown(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            Screen CurrentScreen = Screen.FromControl(this);
            this.Location = new Point(_screen.Bounds.Left + (_screen.Bounds.Width - this.Width) /2, (_screen.Bounds.Height - this.Height) / 2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Channel> tempChannels = Init.GetChannels.ToList();
            tempChannels.Add(new Channel 
            {
                Name = "001",
                Unit = "--",
                Address = 0,
                ByteNum = 2,
                Coeff = 1,
                ReadMul = true,
                WriteMul = true,
                DataType = ModbusType.Float,
                ByteOrder = OrderWay.小端,
                BitOrder = OrderWay.小端,
                OutTime = 1000
            });
            Init.GetChannels = tempChannels;
        }
    }
}
