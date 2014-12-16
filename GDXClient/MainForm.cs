using org.phprpc;
using org.phprpc.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDXClient
{
    public partial class MainForm : Form
    {
        private int pageForPrize = 1;
        private DateTimePicker dtp;
        public MainForm()
        {
            InitializeComponent();
            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-M-dd";
            dtp.ValueChanged += Dtp_ValueChanged;
            ToolStripControlHost dateItem = new ToolStripControlHost(dtp);
            toolStrip5.Items.Add(dateItem);
            dataGridView5.Rows.Add(new object[] { 1, "乐元素", "13:00", "14:00", 500, "派送中", "索要发票" });
            dataGridView5.Rows.Add(new object[] { 2, "搜狗", "13:00", "14:00", 500, "生产中", "索要发票" });
            dataGridView6.Rows.Add(new object[] { 3, "三果切A", 50, "香蕉换草莓" });
            dataGridView6.Rows.Add(new object[] { 3, "单果切B", 150, "杨梅" });
            dataGridView6.Rows.Add(new object[] { 3, "单果切B", 150, "杨梅" });
            dataGridView6.Rows.Add(new object[] { 3, "单果切B", 150, "杨梅" });
            dataGridView6.Rows.Add(new object[] { 3, "单果切B", 150, "杨梅" });
            dataGridView6.Rows.Add(new object[] { 3, "单果切B", 150, "杨梅" });
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

        private void getFruitType_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView1.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["name"])});
            }
        }

        private void getFruit_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView2.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["name"]),
                                                        Encoding.UTF8.GetString((byte[])line["level"]),
                                                        Encoding.UTF8.GetString((byte[])line["area"]),
                                                        Encoding.UTF8.GetString((byte[])line["unit"]),
                                                        Encoding.UTF8.GetString((byte[])line["description"]),
                                                        Encoding.UTF8.GetString((byte[])line["loss"])});
            }
        }

        private void getFruitPrice_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView3.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["minPrice"]),
                                                        Encoding.UTF8.GetString((byte[])line["maxPrice"]),
                                                        Encoding.UTF8.GetString((byte[])line["cdate"])});
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

        private void getPrizeOfUser_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result.Count == 0)
            {
                if (pageForPrize > 1)
                    pageForPrize--;
                return;
            }
            dataGridView4.Rows.Clear();
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView4.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["prizeName"]),
                                                        Encoding.UTF8.GetString((byte[])line["received"]),
                                                        line["location"] == null ? "": Encoding.UTF8.GetString((byte[])line["location"]),
                                                        line["phone"] == null ? "": Encoding.UTF8.GetString((byte[])line["location"]),
                                                        String.Format("{0}", Util.UTCToDateTime(Convert.ToInt32(Encoding.UTF8.GetString((byte[])line["ctime"]))))});
            }
        }

        private void updateReceived_callback(int result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result > 0)
            {
                MessageBox.Show("修改成功");
                SysPublic.getInstance().getService().GetUserForPrize(pageForPrize, getPrizeOfUser_callback);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getFruitType();
            getOrder();
        }

        private void getOrder()
        {
            dataGridView5.Rows.Clear();
            SysPublic.getInstance().getService().GetOrder(dtp.Text.Trim(), getOrder_callback);
        }

        private void getFruitType()
        {
            dataGridView1.Rows.Clear();
            SysPublic.getInstance().getService().GetFruitType(getFruitType_callback);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            getFruit();
        }

        private void getFruit()
        {
            dataGridView2.Rows.Clear();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SysPublic.getInstance().getService().GetFruit(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), getFruit_callback);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            getFruitPrice();
        }

        private void getFruitPrice()
        {
            dataGridView3.Rows.Clear();
            if (dataGridView2.SelectedRows.Count == 1)
            {
                SysPublic.getInstance().getService().GetFruitPrice(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()), getFruitPrice_callback);
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            FruitTypeForm ftf = new FruitTypeForm(FruitTypeForm.MODE.ADD);
            if (ftf.ShowDialog() == DialogResult.OK)
            {
                getFruitType();
            }
        }

        private void addButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                FruitForm ff = new FruitForm(FruitTypeForm.MODE.ADD, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), (string)dataGridView1.SelectedRows[0].Cells[1].Value);
                if (ff.ShowDialog() == DialogResult.OK)
                {
                    getFruit();
                }
            }
        }

        private void addButton7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                FruitPriceForm fpf = new FruitPriceForm(FruitTypeForm.MODE.ADD, Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value), (string)dataGridView2.SelectedRows[0].Cells[1].Value);
                if (fpf.ShowDialog() == DialogResult.OK)
                {
                    getFruitPrice();
                }
            }
        }

        private void updateButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                FruitTypeForm ftf = new FruitTypeForm(FruitTypeForm.MODE.EDIT, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), (string)dataGridView1.SelectedRows[0].Cells[1].Value);
                if (ftf.ShowDialog() == DialogResult.OK)
                {
                    getFruitType();
                }
            }
        }

        private void updateButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                FruitForm ff = new FruitForm(FruitTypeForm.MODE.EDIT, Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value),
                                                                        (string)dataGridView2.SelectedRows[0].Cells[1].Value,
                                                                        Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[2].Value),
                                                                        (string)dataGridView2.SelectedRows[0].Cells[3].Value,
                                                                        (string)dataGridView2.SelectedRows[0].Cells[4].Value,
                                                                        (string)dataGridView2.SelectedRows[0].Cells[5].Value,
                                                                        (float)Convert.ToDouble(dataGridView2.SelectedRows[0].Cells[6].Value));
                if (ff.ShowDialog() == DialogResult.OK)
                {
                    getFruit();
                }
            }
        }

        private void updateButton8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                FruitPriceForm fpf = new FruitPriceForm(FruitTypeForm.MODE.EDIT, Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value),
                    (float)Convert.ToDouble(dataGridView3.SelectedRows[0].Cells[1].Value),
                    (float)Convert.ToDouble(dataGridView3.SelectedRows[0].Cells[2].Value),
                    (string)dataGridView3.SelectedRows[0].Cells[3].Value);
                if (fpf.ShowDialog() == DialogResult.OK)
                {
                    getFruitPrice();
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1] || dataGridView4.Rows.Count == 0)
            {
                first_Click(null, null);
            }
        }

        private void first_Click(object sender, EventArgs e)
        {
            SysPublic.getInstance().getService().GetUserForPrize(1, getPrizeOfUser_callback);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (pageForPrize == 1)
                return;
            SysPublic.getInstance().getService().GetUserForPrize(--pageForPrize, getPrizeOfUser_callback);
        }

        private void next_Click(object sender, EventArgs e)
        {
            SysPublic.getInstance().getService().GetUserForPrize(++pageForPrize, getPrizeOfUser_callback);
        }

        private void updateReceived_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32((string)dataGridView4.SelectedRows[0].Cells[0].Value);
                int received = Convert.ToInt32((string)dataGridView4.SelectedRows[0].Cells[2].Value);
                SysPublic.getInstance().getService().UpdateReceived(id, received == 0 ? 1 : 0, updateReceived_callback);
            }
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
