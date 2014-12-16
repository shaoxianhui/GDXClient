namespace GDXClient
{
    partial class FruitPriceForm
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
            this.fruitName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cdate = new System.Windows.Forms.DateTimePicker();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fruitName
            // 
            this.fruitName.Location = new System.Drawing.Point(184, 27);
            this.fruitName.Name = "fruitName";
            this.fruitName.ReadOnly = true;
            this.fruitName.Size = new System.Drawing.Size(106, 20);
            this.fruitName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "水果名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "日期：";
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(184, 133);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(106, 20);
            this.maxPrice.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "最高价格：";
            // 
            // minPrice
            // 
            this.minPrice.Location = new System.Drawing.Point(184, 80);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(106, 20);
            this.minPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "最低价格：";
            // 
            // cdate
            // 
            this.cdate.CustomFormat = "yyyy-M-dd";
            this.cdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdate.Location = new System.Drawing.Point(184, 186);
            this.cdate.Name = "cdate";
            this.cdate.Size = new System.Drawing.Size(106, 20);
            this.cdate.TabIndex = 20;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(215, 253);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 22;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_update_button
            // 
            this.add_update_button.Location = new System.Drawing.Point(67, 253);
            this.add_update_button.Name = "add_update_button";
            this.add_update_button.Size = new System.Drawing.Size(75, 23);
            this.add_update_button.TabIndex = 21;
            this.add_update_button.Text = "保存";
            this.add_update_button.UseVisualStyleBackColor = true;
            this.add_update_button.Click += new System.EventHandler(this.add_update_button_Click);
            // 
            // FruitPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 297);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_update_button);
            this.Controls.Add(this.cdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fruitName);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FruitPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "水果价格";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fruitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker cdate;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_update_button;
    }
}