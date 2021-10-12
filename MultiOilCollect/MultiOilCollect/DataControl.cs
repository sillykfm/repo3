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
    public partial class DataControl : UserControl
    {
        List<string> memoeryAdd = new List<string>() { "线圈状态(RW)", "离散输入(RO)", "保持寄存器(RW)", "输入寄存器(RO)" };
        string[] dataTypes = System.Enum.GetNames(typeof(ModbusType));
        string[] orderTypes = System.Enum.GetNames(typeof(OrderWay));

        public DataControl()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoGenerateColumns = false;
            Init.channelChangeEvent += FreshChannelDatagrid;
        }

        private static DataControl _itSelf = null;
        public static DataControl ItSelf
        {
            get 
            {
                if (_itSelf == null)
                {
                    _itSelf = new DataControl();
                }
                return _itSelf;
            }
        }

        private void DataControl_Load(object sender, EventArgs e)
        {
            //Init.channelChangeEvent += FreshChannelDatagrid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Screen CurrentScreen = Screen.FromControl(this);
            DataAddForm dataAddForm = DataAddForm.GetSigForm(CurrentScreen);
            var screenPoint = PointToScreen(new Point(400,400));
            dataAddForm.ShowDialog();
            FreshChannelDatagrid(Init.GetChannels);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Init.GetChannels;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Style.NullValue = memoeryAdd[(int)Init.GetChannels[i].ModbusArea];
                dataGridView1.Rows[i].Cells[9].Style.NullValue = dataTypes[(int)Init.GetChannels[i].DataType];
                dataGridView1.Rows[i].Cells[10].Style.NullValue = orderTypes[(int)Init.GetChannels[i].ByteOrder];
                dataGridView1.Rows[i].Cells[11].Style.NullValue = orderTypes[(int)Init.GetChannels[i].BitOrder];
            }
        }

        public void FreshChannelDatagrid(List<Channel> channels)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Init.GetChannels;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Style.NullValue = memoeryAdd[(int)Init.GetChannels[i].ModbusArea];
                dataGridView1.Rows[i].Cells[9].Style.NullValue = dataTypes[(int)Init.GetChannels[i].DataType];
                dataGridView1.Rows[i].Cells[10].Style.NullValue = orderTypes[(int)Init.GetChannels[i].ByteOrder];
                dataGridView1.Rows[i].Cells[11].Style.NullValue = orderTypes[(int)Init.GetChannels[i].BitOrder];
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
