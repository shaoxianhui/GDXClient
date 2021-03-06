﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.phprpc;

namespace GDXClient
{
    public partial class OrderForm : Form
    {
        private FruitTypeForm.MODE _mode = FruitTypeForm.MODE.ADD;
        private int _id;
        private string _cdate;
        private string _customer;
        private string _earliest;
        private string _latest;
        private string _comment;

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(FruitTypeForm.MODE mode)
        {
            InitializeComponent();
            this._mode = mode;
        }

        public OrderForm(FruitTypeForm.MODE mode, int orderId, string cdate, string customer, string earliest, string latest, string comment)
        {
            InitializeComponent();
            this._mode = mode;
            this._id = orderId;
            this._cdate = cdate;
            this._customer = customer;
            this._earliest = earliest;
            this._latest = latest;
            this._comment = comment;
            this.customer.Text = this._customer;
            this.latest.Text = this._latest;
            this.earliest.Text = this._earliest;
            this.comment.Text = this._comment;
            this.cdate.Text = this._cdate;
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customer.Text.Trim()))
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                if (_mode == FruitTypeForm.MODE.ADD)
                {
                    SysPublic.getInstance().getService().AddOrder(customer.Text.Trim(), cdate.Text.Trim(), earliest.Text.Trim(), latest.Text.Trim(), comment.Text.Trim(), Order_callback);
                }
                else if (_mode == FruitTypeForm.MODE.EDIT)
                {
                    SysPublic.getInstance().getService().UpdateOrder(_id, customer.Text.Trim(), cdate.Text.Trim(), earliest.Text.Trim(), latest.Text.Trim(), comment.Text.Trim(), Order_callback);
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Order_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if (Result == 0)
            {
                MessageBox.Show("操作失败");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
