namespace GDXClient
{
    partial class OrderItemForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "客户名称：";
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(166, 22);
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Size = new System.Drawing.Size(159, 21);
            this.customer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "商品名称：";
            // 
            // product
            // 
            this.product.FormattingEnabled = true;
            this.product.Location = new System.Drawing.Point(166, 68);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(159, 20);
            this.product.TabIndex = 14;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(166, 114);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(159, 21);
            this.quantity.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "个数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "单价：";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(166, 160);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(159, 21);
            this.money.TabIndex = 18;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(166, 210);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.comment.Size = new System.Drawing.Size(159, 121);
            this.comment.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "详细：";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(230, 350);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 21);
            this.cancel_button.TabIndex = 22;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_update_button
            // 
            this.add_update_button.Location = new System.Drawing.Point(59, 350);
            this.add_update_button.Name = "add_update_button";
            this.add_update_button.Size = new System.Drawing.Size(75, 21);
            this.add_update_button.TabIndex = 21;
            this.add_update_button.Text = "保存";
            this.add_update_button.UseVisualStyleBackColor = true;
            this.add_update_button.Click += new System.EventHandler(this.add_update_button_Click);
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 393);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_update_button);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label2);
            this.Name = "OrderItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单项";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox product;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_update_button;
    }
}