using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.phprpc;
using System.Collections;
using org.phprpc.util;

namespace GDXClient
{
    public partial class OrderEditControl : UserControl
    {
        private DateTimePicker dtp;
        public OrderEditControl()
        {
            InitializeComponent();
            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-M-dd";
            dtp.ValueChanged += Dtp_ValueChanged;
            ToolStripControlHost dateItem = new ToolStripControlHost(dtp);
            toolStrip5.Items.Add(dateItem);
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            getOrder();
        }

        private void getOrder_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result == null)
                return;
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView5.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["customer"]),
                                                        Encoding.UTF8.GetString((byte[])line["earliest"]),
                                                        Encoding.UTF8.GetString((byte[])line["latest"]),
                                                        Encoding.UTF8.GetString((byte[])line["status"]),
                                                        Encoding.UTF8.GetString((byte[])line["comment"]),
                });
            }
        }

        private void getOrderItem_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result == null)
                return;
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView6.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["product"]),
                                                        Encoding.UTF8.GetString((byte[])line["quantity"]),
                                                        Encoding.UTF8.GetString((byte[])line["money"]),
                                                        Encoding.UTF8.GetString((byte[])line["comment"])});
            }
        }

        private void OrderEditControl_Load(object sender, EventArgs e)
        {
            getOrder();
        }

        private void getOrder()
        {
            dataGridView5.Rows.Clear();
            SysPublic.getInstance().getService().GetOrder(dtp.Value.ToString().Trim(), getOrder_callback);
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            getOrderItem();
        }

        private void getOrderItem()
        {
            dataGridView6.Rows.Clear();
            if (dataGridView5.SelectedRows.Count == 1)
            {
                SysPublic.getInstance().getService().GetOrderItem(Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()), getOrderItem_callback);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OrderForm df = new OrderForm(FruitTypeForm.MODE.ADD);
            if (df.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("成功");
            }
            getOrder();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 1)
            {
                OrderItemForm oif = new OrderItemForm(FruitTypeForm.MODE.ADD, Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()), dataGridView5.SelectedRows[0].Cells[1].Value.ToString());
                if (oif.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("成功");
                }
            }
            getOrderItem();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 1)
            {
                OrderForm df = new OrderForm(FruitTypeForm.MODE.EDIT, Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()),
                                                                        dtp.Text, dataGridView5.SelectedRows[0].Cells[1].Value.ToString(),
                                                                        dataGridView5.SelectedRows[0].Cells[2].Value.ToString(),
                                                                        dataGridView5.SelectedRows[0].Cells[3].Value.ToString(),
                                                                        dataGridView5.SelectedRows[0].Cells[5].Value.ToString());
                if (df.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("成功");
                }
            }
            getOrder();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count == 1)
            {
                OrderItemForm oif = new OrderItemForm(FruitTypeForm.MODE.EDIT, dataGridView5.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToInt32(dataGridView6.SelectedRows[0].Cells[0].Value.ToString()),
                    dataGridView6.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToInt32(dataGridView6.SelectedRows[0].Cells[2].Value.ToString()),
                    float.Parse(dataGridView6.SelectedRows[0].Cells[3].Value.ToString()),
                    dataGridView6.SelectedRows[0].Cells[4].Value.ToString());
                if (oif.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("成功");
                }
            }
            getOrderItem();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除此订单？", "删除警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SysPublic.getInstance().getService().DeleteOrder(Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()), DeleteOrder_callback);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除此订单项？", "删除警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SysPublic.getInstance().getService().DeleteOrderItem(Convert.ToInt32(dataGridView6.SelectedRows[0].Cells[0].Value.ToString()), DeleteOrderItem_callback);
            }
        }

        private void DeleteOrder_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if (Result == 0)
            {
                MessageBox.Show("操作失败");
            }
            getOrder();
        }

        private void DeleteOrderItem_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if (Result == 0)
            {
                MessageBox.Show("操作失败");
            }
            getOrderItem();
        }

    }
}
