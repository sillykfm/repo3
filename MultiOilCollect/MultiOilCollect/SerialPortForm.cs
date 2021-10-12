using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiOilCollect
{
    public delegate void DelUpdata();
    public partial class SerialPortForm : Form
    {
        public DelUpdata _delUpdata;
        public bool isNewForm;
        public int connectIndex;
        string[] paraMeters = new string[] { "COM口", "传输模式", "波特率", "校验方式", "停止位" };
        string[] portNames = SerialPort.GetPortNames();
        string[] transWay = new string[] { "MODBUS_RTU","MODBUS_ASCII"};
        string[] baudRate = new string[] { "1200","2400","4800","9600","19200","38400","57600","115200"};
        string[] check = new string[] { "None", "Odd", "Even" };
        string[] stopBit = new string[] { "1","1.5","2"};
        
        
        public SerialPortForm()
        {           
            InitializeComponent();
            object[] paraValues = new object[] { portNames, transWay, baudRate , check , stopBit };
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.RowTemplate.Height = 50;
            AddNewRowToGrid("链接名称", "NET001");
            for (int i = 0; i < paraMeters.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textboxcel = new DataGridViewTextBoxCell();
                textboxcel.Value = paraMeters[i];
                row.Cells.Add(textboxcel);
                DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
                comboxcell.DataSource = paraValues[i];
                comboxcell.Value = i == 2 ? ((string[])paraValues[i])[3] : ((string[])paraValues[i])[0];               
                row.Cells.Add(comboxcell);
                dataGridView1.Rows.Add(row);
            }
            AddNewRowToGrid("备注", "");
        }

        private static SerialPortForm _serialForm = null;
        public static SerialPortForm GetSigleForm(DelUpdata delUpdata)
        {
            if (_serialForm == null)
            {
                _serialForm = new SerialPortForm();
                _serialForm._delUpdata = delUpdata;
                _serialForm.isNewForm = true;
            }
            return _serialForm;
        }

        public static SerialPortForm GetSigleForm(DelUpdata delUpdata,int index)
        {
            if (_serialForm == null)
            {
                _serialForm = new SerialPortForm();
                _serialForm._delUpdata = delUpdata;
                _serialForm.isNewForm = false;
                _serialForm.connectIndex = index;
                List<string> tempParameter = new List<string>() { Init.connects[index].ConnectName,Init.connects[index].ModbusPara.SerialPort, Init.connects[index].ModbusPara.TransWay.ToString(), Init.connects[index].ModbusPara.BaudRate.ToString(), Init.connects[index].ModbusPara.CheckWay.ToString(), Init.connects[index].ModbusPara.StopBit.ToString(), Init.connects[index].Remark};
                for (int i = 0; i < _serialForm.dataGridView1.RowCount; i++)
                {
                    _serialForm.dataGridView1.Rows[i].Cells[1].Value = tempParameter[i];
                }
            }
            return _serialForm;
        }

        private void SerialPortForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[1].Value.ToString().Trim().Length == 0)
            {
                MessageBox.Show("请填入链接名称","提示");
                return;
            }
            string currentConnectName = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim();
            string serialName = dataGridView1.Rows[1].Cells[1].Value.ToString().Trim();

            //is new form
            if (isNewForm)
            {               
                if (Init.connects.Select(s => s.ConnectName).ToList().Contains(currentConnectName))
                {
                    MessageBox.Show("链接名称已存在，请修改", "提示");
                    return;
                }               
                if (Init.connects.Select(s => s.ModbusPara.SerialPort).ToList().Contains(serialName))
                {
                    MessageBox.Show("该串口已使用，请修改", "提示");
                    return;
                }
                ModbusPara modbusPara = new ModbusPara()
                {
                    SerialPort = dataGridView1.Rows[1].Cells[1].Value.ToString().Trim(),
                    TransWay = (TransWay)Enum.Parse(typeof(TransWay), dataGridView1.Rows[2].Cells[1].Value.ToString().Trim()),
                    BaudRate = int.Parse(dataGridView1.Rows[3].Cells[1].Value.ToString().Trim()),
                    CheckWay = (CheckWay)Enum.Parse(typeof(CheckWay), dataGridView1.Rows[4].Cells[1].Value.ToString().Trim()),
                    StopBit = int.Parse(dataGridView1.Rows[5].Cells[1].Value.ToString().Trim())
                };
                Init.connects.Add(new Connect
                {
                    ConnectName = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim(),
                    AddressStart = 1,
                    AddressEnd = 1,
                    ModbusPara = modbusPara,
                    Remark = dataGridView1.Rows[6].Cells[1].Value.ToString().Trim()
                });
            }
            else
            {
                //this.dataGridView1.Rows[0].Cells[1].ReadOnly = true;
                ModbusPara modbusPara = Init.connects[connectIndex].ModbusPara;
                List<string> connectNames = Init.connects.Select(s => s.ConnectName).ToList();
                connectNames.Remove(Init.connects[connectIndex].ConnectName);
                List<string> serialPorts = Init.connects.Select(s => s.ModbusPara.SerialPort).ToList();
                serialPorts.Remove(modbusPara.SerialPort);
                if (connectNames.Contains(currentConnectName))
                {
                    MessageBox.Show("链接名称已被使用，请修改", "提示");
                    return;
                }
                if (serialPorts.Contains(serialName))
                {
                    MessageBox.Show("该串口已被使用，请修改", "提示");
                    return;
                }
                Init.connects[connectIndex].ConnectName = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim();
                Init.connects[connectIndex].ModbusPara.SerialPort = dataGridView1.Rows[1].Cells[1].Value.ToString().Trim();
                Init.connects[connectIndex].ModbusPara.TransWay = (TransWay)Enum.Parse(typeof(TransWay), dataGridView1.Rows[2].Cells[1].Value.ToString().Trim());
                Init.connects[connectIndex].ModbusPara.BaudRate = int.Parse(dataGridView1.Rows[3].Cells[1].Value.ToString().Trim());
                Init.connects[connectIndex].ModbusPara.CheckWay = (CheckWay)Enum.Parse(typeof(CheckWay), dataGridView1.Rows[4].Cells[1].Value.ToString().Trim());
                Init.connects[connectIndex].ModbusPara.StopBit = int.Parse(dataGridView1.Rows[5].Cells[1].Value.ToString().Trim());
            }
            Init.MacNum = Init.connects.Count;
            //委托传值
            _delUpdata.Invoke();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void AddNewRowToGrid(string str1,string str2)
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

        private void SerialPortForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialForm = null;
        }
    }
}
