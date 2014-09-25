namespace GDXClient
{
    partial class FruitForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_update_button = new System.Windows.Forms.Button();
            this.fruitTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(221, 397);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_update_button
            // 
            this.add_update_button.Location = new System.Drawing.Point(57, 397);
            this.add_update_button.Name = "add_update_button";
            this.add_update_button.Size = new System.Drawing.Size(75, 23);
            this.add_update_button.TabIndex = 6;
            this.add_update_button.Text = "保存";
            this.add_update_button.UseVisualStyleBackColor = true;
            this.add_update_button.Click += new System.EventHandler(this.add_update_button_Click);
            // 
            // fruitTypeName
            // 
            this.fruitTypeName.Location = new System.Drawing.Point(190, 28);
            this.fruitTypeName.Name = "fruitTypeName";
            this.fruitTypeName.ReadOnly = true;
            this.fruitTypeName.Size = new System.Drawing.Size(106, 20);
            this.fruitTypeName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "类别名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "水果名称：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(190, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 20);
            this.name.TabIndex = 9;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(190, 116);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(106, 20);
            this.level.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "等级：";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(190, 160);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(106, 20);
            this.area.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "产地：";
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(190, 204);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(106, 20);
            this.unit.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "单位：";
            // 
            // loss
            // 
            this.loss.Location = new System.Drawing.Point(190, 361);
            this.loss.Name = "loss";
            this.loss.Size = new System.Drawing.Size(106, 20);
            this.loss.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "损耗：";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(190, 248);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(106, 92);
            this.description.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "描述：";
            // 
            // FruitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 432);
            this.Controls.Add(this.loss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_update_button);
            this.Controls.Add(this.fruitTypeName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FruitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "水果";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_update_button;
        private System.Windows.Forms.TextBox fruitTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label8;
    }
}