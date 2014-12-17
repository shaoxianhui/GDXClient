namespace GDXClient
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.order_list = new System.Windows.Forms.ToolStripMenuItem();
            this.order_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.fruit_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.customer_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.prize_list = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.work = new System.Windows.Forms.Panel();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Chocolate;
            this.title.Controls.Add(this.pictureBox1);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1206, 105);
            this.title.TabIndex = 0;
            this.title.DoubleClick += new System.EventHandler(this.title_DoubleClick);
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_list,
            this.order_edit,
            this.fruit_edit,
            this.customer_edit,
            this.prize_list,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 105);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // order_list
            // 
            this.order_list.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_list.ForeColor = System.Drawing.Color.Gold;
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(67, 20);
            this.order_list.Text = "订单详情";
            this.order_list.Click += new System.EventHandler(this.menu_Click);
            // 
            // order_edit
            // 
            this.order_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_edit.ForeColor = System.Drawing.Color.Gold;
            this.order_edit.Name = "order_edit";
            this.order_edit.Size = new System.Drawing.Size(67, 20);
            this.order_edit.Text = "订单管理";
            this.order_edit.Click += new System.EventHandler(this.menu_Click);
            // 
            // fruit_edit
            // 
            this.fruit_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fruit_edit.ForeColor = System.Drawing.Color.Gold;
            this.fruit_edit.Name = "fruit_edit";
            this.fruit_edit.Size = new System.Drawing.Size(67, 20);
            this.fruit_edit.Text = "水果管理";
            this.fruit_edit.Click += new System.EventHandler(this.menu_Click);
            // 
            // customer_edit
            // 
            this.customer_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_edit.ForeColor = System.Drawing.Color.Gold;
            this.customer_edit.Name = "customer_edit";
            this.customer_edit.Size = new System.Drawing.Size(67, 20);
            this.customer_edit.Text = "客户管理";
            this.customer_edit.Click += new System.EventHandler(this.menu_Click);
            // 
            // prize_list
            // 
            this.prize_list.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prize_list.ForeColor = System.Drawing.Color.Gold;
            this.prize_list.Name = "prize_list";
            this.prize_list.Size = new System.Drawing.Size(67, 20);
            this.prize_list.Text = "奖品管理";
            this.prize_list.Click += new System.EventHandler(this.menu_Click);
            // 
            // exit
            // 
            this.exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.ForeColor = System.Drawing.Color.Gold;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(43, 20);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.Color.YellowGreen;
            this.work.Dock = System.Windows.Forms.DockStyle.Fill;
            this.work.Location = new System.Drawing.Point(0, 129);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(1206, 496);
            this.work.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1206, 625);
            this.Controls.Add(this.work);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDX";
            this.Load += new System.EventHandler(this.main_Load);
            this.title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel work;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem order_list;
        private System.Windows.Forms.ToolStripMenuItem order_edit;
        private System.Windows.Forms.ToolStripMenuItem fruit_edit;
        private System.Windows.Forms.ToolStripMenuItem prize_list;
        private System.Windows.Forms.ToolStripMenuItem customer_edit;
    }
}