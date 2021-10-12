
namespace MultiOilCollect
{
    partial class ConnectForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConnectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraMeter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.operat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addressStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(128, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新建链接";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DimGray;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(301, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "移除链接";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(18, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectName,
            this.ConnectState,
            this.paraMeter,
            this.operat,
            this.addressStart,
            this.addressEnd,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 558);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // ConnectName
            // 
            this.ConnectName.DataPropertyName = "ConnectName";
            this.ConnectName.HeaderText = "链接";
            this.ConnectName.MinimumWidth = 8;
            this.ConnectName.Name = "ConnectName";
            // 
            // ConnectState
            // 
            this.ConnectState.DataPropertyName = "ConnectState";
            this.ConnectState.HeaderText = "链接状态";
            this.ConnectState.MinimumWidth = 8;
            this.ConnectState.Name = "ConnectState";
            // 
            // paraMeter
            // 
            this.paraMeter.HeaderText = "链接参数";
            this.paraMeter.MinimumWidth = 8;
            this.paraMeter.Name = "paraMeter";
            this.paraMeter.Text = "配置";
            this.paraMeter.UseColumnTextForButtonValue = true;
            // 
            // operat
            // 
            this.operat.HeaderText = "链接操作";
            this.operat.MinimumWidth = 8;
            this.operat.Name = "operat";
            this.operat.Text = "";
            // 
            // addressStart
            // 
            this.addressStart.DataPropertyName = "AddressStart";
            this.addressStart.HeaderText = "设备起始地址";
            this.addressStart.MinimumWidth = 8;
            this.addressStart.Name = "addressStart";
            this.addressStart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addressEnd
            // 
            this.addressEnd.DataPropertyName = "AddressEnd";
            this.addressEnd.HeaderText = "设备结束地址";
            this.addressEnd.MinimumWidth = 8;
            this.addressEnd.Name = "addressEnd";
            this.addressEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "Remark";
            this.remark.HeaderText = "备注";
            this.remark.MinimumWidth = 8;
            this.remark.Name = "remark";
            this.remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "ConnectForm";
            this.Size = new System.Drawing.Size(1117, 614);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectState;
        private System.Windows.Forms.DataGridViewButtonColumn paraMeter;
        private System.Windows.Forms.DataGridViewButtonColumn operat;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}
