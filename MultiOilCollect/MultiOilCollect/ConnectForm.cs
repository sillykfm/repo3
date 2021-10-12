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
    public partial class ConnectForm : UserControl
    {
        public ConnectForm()
        {            
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            
        }

        private static ConnectForm _ItSelf = null;
        public static ConnectForm ItSelf
        {
            get
            {
                if (_ItSelf == null)
                {
                    _ItSelf = new ConnectForm();
                }
                //_ItSelf.UpdataGridView();
                return _ItSelf;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SerialPortForm serialPortForm = SerialPortForm.GetSigleForm(UpdataGridView);
            serialPortForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "paraMeter" && e.RowIndex >= 0)
            {
                SerialPortForm serialPortForm = SerialPortForm.GetSigleForm(UpdataGridView, e.RowIndex);
                serialPortForm.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "operat" && e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "启动")
                {
                    Init.connects[e.RowIndex].ConnectState = true;
                    UpdataGridView();
                    return;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "关闭")
                {
                    Init.connects[e.RowIndex].ConnectState = false;
                    UpdataGridView();
                    return;
                }
            }
            dataGridView1.Visible = true;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = "启动";
        }

        public void UpdataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Init.connects;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                bool state = Init.connects[i].ConnectState;
                if (!state)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "启动";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = "关闭";
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Green;
                }
            }
        }

    }
}
