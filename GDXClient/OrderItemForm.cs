using System;
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
    public partial class OrderItemForm : Form
    {
        private FruitTypeForm.MODE _mode = FruitTypeForm.MODE.ADD;
        private int _id;
        private int _orderId;
        private string _customer;
        private string _product;
        private int _quantity;
        private float _money;
        private string _comment;

        public OrderItemForm(FruitTypeForm.MODE mode, int orderId, string customer)
        {
            InitializeComponent();
            this._mode = mode;
            this._orderId = orderId;
            this._customer = customer;
            this.customer.Text = this._customer;
        }

        public OrderItemForm(FruitTypeForm.MODE mode, string customer, int orderItemId, string product, int quantity, float money, string comment)
        {
            InitializeComponent();
            this._mode = mode;
            this._customer = customer;
            this._id = orderItemId;
            this._product = product;
            this._money = money;
            this._quantity = quantity;
            this._comment = comment;
            this.customer.Text = this._customer;
            this.product.Text = this._product;
            this.quantity.Value = this._quantity;
            this.money.Text = this._money.ToString();
            this.comment.Text = this._comment;
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(product.Text.Trim()))
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                if (_mode == FruitTypeForm.MODE.ADD)
                {
                    SysPublic.getInstance().getService().AddOrderItem(_orderId, product.Text.Trim(), Convert.ToInt32(quantity.Value), float.Parse(money.Text.Trim()), comment.Text.Trim(), OrderItem_callback);
                }
                else if (_mode == FruitTypeForm.MODE.EDIT)
                {
                    SysPublic.getInstance().getService().UpdateOrderItem(_id, product.Text.Trim(), Convert.ToInt32(quantity.Value), float.Parse(money.Text.Trim()), comment.Text.Trim(), OrderItem_callback);
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OrderItem_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
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
