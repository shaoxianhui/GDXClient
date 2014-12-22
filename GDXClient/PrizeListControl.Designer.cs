namespace GDXClient
{
    partial class PrizeListControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrizeListControl));
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.updateReceived = new System.Windows.Forms.ToolStripButton();
            this.first = new System.Windows.Forms.ToolStripButton();
            this.prev = new System.Windows.Forms.ToolStripButton();
            this.next = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.phone,
            this.location,
            this.prize,
            this.received,
            this.ctime});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 25);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1034, 594);
            this.dataGridView4.TabIndex = 5;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateReceived,
            this.first,
            this.prev,
            this.next});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip4.TabIndex = 4;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // updateReceived
            // 
            this.updateReceived.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateReceived.Image = ((System.Drawing.Image)(resources.GetObject("updateReceived.Image")));
            this.updateReceived.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateReceived.Name = "updateReceived";
            this.updateReceived.Size = new System.Drawing.Size(23, 22);
            this.updateReceived.Text = "修改";
            this.updateReceived.Click += new System.EventHandler(this.updateReceived_Click);
            // 
            // first
            // 
            this.first.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.first.Image = ((System.Drawing.Image)(resources.GetObject("first.Image")));
            this.first.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(35, 22);
            this.first.Text = "首页";
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // prev
            // 
            this.prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prev.Image = ((System.Drawing.Image)(resources.GetObject("prev.Image")));
            this.prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(47, 22);
            this.prev.Text = "上一页";
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(47, 22);
            this.next.Text = "下一页";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // phone
            // 
            this.phone.HeaderText = "联系电话";
            this.phone.Name = "phone";
            // 
            // location
            // 
            this.location.HeaderText = "详细内容";
            this.location.Name = "location";
            // 
            // prize
            // 
            this.prize.HeaderText = "奖品";
            this.prize.Name = "prize";
            // 
            // received
            // 
            this.received.HeaderText = "是否送达";
            this.received.Name = "received";
            // 
            // ctime
            // 
            this.ctime.HeaderText = "日期";
            this.ctime.Name = "ctime";
            // 
            // PrizeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.toolStrip4);
            this.Name = "PrizeListControl";
            this.Size = new System.Drawing.Size(1034, 619);
            this.Load += new System.EventHandler(this.PrizeListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton updateReceived;
        private System.Windows.Forms.ToolStripButton first;
        private System.Windows.Forms.ToolStripButton prev;
        private System.Windows.Forms.ToolStripButton next;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn prize;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctime;
    }
}
