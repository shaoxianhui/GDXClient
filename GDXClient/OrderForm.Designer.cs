﻿namespace GDXClient
{
    partial class OrderForm
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
            this.customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.earliest = new System.Windows.Forms.DateTimePicker();
            this.latest = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_update_button = new System.Windows.Forms.Button();
            this.cdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "客户名称：";
            // 
            // customer
            // 
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(162, 32);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(159, 20);
            this.customer.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "最早送达时间：";
            // 
            // earliest
            // 
            this.earliest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.earliest.Location = new System.Drawing.Point(162, 114);
            this.earliest.Name = "earliest";
            this.earliest.Size = new System.Drawing.Size(159, 21);
            this.earliest.TabIndex = 13;
            // 
            // latest
            // 
            this.latest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.latest.Location = new System.Drawing.Point(162, 155);
            this.latest.Name = "latest";
            this.latest.Size = new System.Drawing.Size(159, 21);
            this.latest.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "最晚送达时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "备注：";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(162, 200);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.comment.Size = new System.Drawing.Size(159, 121);
            this.comment.TabIndex = 17;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(223, 340);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 21);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_update_button
            // 
            this.add_update_button.Location = new System.Drawing.Point(46, 340);
            this.add_update_button.Name = "add_update_button";
            this.add_update_button.Size = new System.Drawing.Size(75, 21);
            this.add_update_button.TabIndex = 18;
            this.add_update_button.Text = "保存";
            this.add_update_button.UseVisualStyleBackColor = true;
            this.add_update_button.Click += new System.EventHandler(this.add_update_button_Click);
            // 
            // cdate
            // 
            this.cdate.CustomFormat = "yyyy-M-dd";
            this.cdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdate.Location = new System.Drawing.Point(162, 73);
            this.cdate.Name = "cdate";
            this.cdate.Size = new System.Drawing.Size(159, 21);
            this.cdate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "送达日期：";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdate);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_update_button);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.latest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.earliest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label2);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker earliest;
        private System.Windows.Forms.DateTimePicker latest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_update_button;
        private System.Windows.Forms.DateTimePicker cdate;
        private System.Windows.Forms.Label label5;
    }
}