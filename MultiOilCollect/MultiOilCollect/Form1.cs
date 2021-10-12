using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiOilCollect
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            dataGridName.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridName.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridName.AutoGenerateColumns = false;
            dataGridName.DefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void connect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ConnectForm.ItSelf);           
            ConnectForm.ItSelf.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(DataControl.ItSelf);
            ConnectForm.ItSelf.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect_ItemClick(null,null);
            Init.changeEvent += UpdataConnectName;
        }

        public void UpdataConnectName(int index)
        {
            dataGridName.DataSource = null;
            dataGridName.DataSource = Init.connects;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "<<")
            {
                panelMain.Visible = false;
                btnShow.Text = ">>";
                return;
            }
            if (btnShow.Text == ">>")
            {
                panelMain.Visible = true;
                btnShow.Text = "<<";
                return;
            }
        }

        private void dataGridName_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridName,e);
        }
    }
}
