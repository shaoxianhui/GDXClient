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
        private int page = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void getFruitType_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            foreach(DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView1.Rows.Add(new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["name"])});
            }
        }

        private void getFruit_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView2.Rows.Add(new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
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
                dataGridView3.Rows.Add(new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["minPrice"]),
                                                        Encoding.UTF8.GetString((byte[])line["maxPrice"]),
                                                        Encoding.UTF8.GetString((byte[])line["cdate"])});
            }
        }

        private void getPrizeOfUser_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result.Count == 0)
            {
                if(page > 1)
                    page--;
                return;
            }
            dataGridView4.Rows.Clear();
            foreach (DictionaryEntry aa in result)
            {
                Hashtable line = PHPConvert.ToHashtable(aa.Value);
                dataGridView4.Rows.Add(new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["prizeName"]),
                                                        Encoding.UTF8.GetString((byte[])line["received"]),
                                                        line["location"] == null ? "": Encoding.UTF8.GetString((byte[])line["location"]),
                                                        line["phone"] == null ? "": Encoding.UTF8.GetString((byte[])line["location"]),
                                                        String.Format("{0}", Util.UTCToDateTime(Convert.ToInt32(Encoding.UTF8.GetString((byte[])line["ctime"]))))});
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getFruitType();
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
            if(ftf.ShowDialog() == DialogResult.OK)
            {
                getFruitType();
            }
        }

        private void addButton4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                FruitForm ff = new FruitForm(FruitTypeForm.MODE.ADD, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), (string)dataGridView1.SelectedRows[0].Cells[1].Value);
                if(ff.ShowDialog() == DialogResult.OK)
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
            if (page == 1)
                return;
            SysPublic.getInstance().getService().GetUserForPrize(--page, getPrizeOfUser_callback);
        }

        private void next_Click(object sender, EventArgs e)
        {
            SysPublic.getInstance().getService().GetUserForPrize(++page, getPrizeOfUser_callback);
        }
    }
}
