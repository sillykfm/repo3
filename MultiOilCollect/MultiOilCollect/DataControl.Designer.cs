
namespace MultiOilCollect
{
    partial class DataControl
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
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MulWrite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ByteWay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BitWay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(17, 14);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(87, 34);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(133, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(244, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChannelName,
            this.Unit,
            this.Area,
            this.Address,
            this.DataNum,
            this.BitNum,
            this.Coeff,
            this.ReadState,
            this.MulWrite,
            this.DataType,
            this.ByteWay,
            this.BitWay,
            this.OutTime});
            this.dataGridView1.Location = new System.Drawing.Point(8, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1423, 520);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(350, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ChannelName
            // 
            this.ChannelName.DataPropertyName = "Name";
            this.ChannelName.FillWeight = 93.17251F;
            this.ChannelName.HeaderText = "名称";
            this.ChannelName.MinimumWidth = 8;
            this.ChannelName.Name = "ChannelName";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 93.17251F;
            this.Unit.HeaderText = "单位";
            this.Unit.MinimumWidth = 8;
            this.Unit.Name = "Unit";
            // 
            // Area
            // 
            this.Area.FillWeight = 147.7273F;
            this.Area.HeaderText = "区块";
            this.Area.Items.AddRange(new object[] {
            "线圈状态_RW",
            "离散输入_RO",
            "保持寄存器_RW",
            "输入寄存器_RO"});
            this.Area.MinimumWidth = 8;
            this.Area.Name = "Area";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 93.17251F;
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataNum
            // 
            this.DataNum.DataPropertyName = "ByteNum";
            this.DataNum.FillWeight = 93.17251F;
            this.DataNum.HeaderText = "数量";
            this.DataNum.MinimumWidth = 8;
            this.DataNum.Name = "DataNum";
            // 
            // BitNum
            // 
            this.BitNum.DataPropertyName = "BitNum";
            this.BitNum.FillWeight = 93.17251F;
            this.BitNum.HeaderText = "位数";
            this.BitNum.MinimumWidth = 8;
            this.BitNum.Name = "BitNum";
            // 
            // Coeff
            // 
            this.Coeff.DataPropertyName = "Coeff";
            this.Coeff.FillWeight = 93.17251F;
            this.Coeff.HeaderText = "系数";
            this.Coeff.MinimumWidth = 8;
            this.Coeff.Name = "Coeff";
            // 
            // ReadState
            // 
            this.ReadState.DataPropertyName = "ReadMul";
            this.ReadState.FillWeight = 93.17251F;
            this.ReadState.HeaderText = "批量读";
            this.ReadState.MinimumWidth = 8;
            this.ReadState.Name = "ReadState";
            // 
            // MulWrite
            // 
            this.MulWrite.DataPropertyName = "WriteMul";
            this.MulWrite.FillWeight = 93.17251F;
            this.MulWrite.HeaderText = "批量写";
            this.MulWrite.MinimumWidth = 8;
            this.MulWrite.Name = "MulWrite";
            // 
            // DataType
            // 
            this.DataType.FillWeight = 93.17251F;
            this.DataType.HeaderText = "数据类型";
            this.DataType.Items.AddRange(new object[] {
            "Int16",
            "UInt16",
            "Int32",
            "UInt32",
            "Float",
            "ASCII",
            "UTF8"});
            this.DataType.MinimumWidth = 8;
            this.DataType.Name = "DataType";
            // 
            // ByteWay
            // 
            this.ByteWay.FillWeight = 93.17251F;
            this.ByteWay.HeaderText = "字节序";
            this.ByteWay.Items.AddRange(new object[] {
            "大端",
            "小端"});
            this.ByteWay.MinimumWidth = 8;
            this.ByteWay.Name = "ByteWay";
            // 
            // BitWay
            // 
            this.BitWay.FillWeight = 93.17251F;
            this.BitWay.HeaderText = "字序";
            this.BitWay.Items.AddRange(new object[] {
            "大端",
            "小端"});
            this.BitWay.MinimumWidth = 8;
            this.BitWay.Name = "BitWay";
            // 
            // OutTime
            // 
            this.OutTime.DataPropertyName = "OutTime";
            this.OutTime.FillWeight = 127.3751F;
            this.OutTime.HeaderText = "超时时间";
            this.OutTime.MinimumWidth = 8;
            this.OutTime.Name = "OutTime";
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnConfig);
            this.Name = "DataControl";
            this.Size = new System.Drawing.Size(1444, 688);
            this.Load += new System.EventHandler(this.DataControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewComboBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coeff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReadState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MulWrite;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ByteWay;
        private System.Windows.Forms.DataGridViewComboBoxColumn BitWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
    }
}
