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

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SysPublic.getInstance().getService().GetFruitType(getFruitType_callback);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if(dataGridView1.SelectedRows.Count == 1)
            {
                SysPublic.getInstance().getService().GetFruit(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), getFruit_callback);
            }
            
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            if(dataGridView2.SelectedRows.Count == 1)
            {
                SysPublic.getInstance().getService().GetFruitPrice(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()), getFruitPrice_callback);
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            FruitTypeForm ftf = new FruitTypeForm(FruitTypeForm.MODE.ADD);
            if(ftf.ShowDialog() == DialogResult.OK)
            {
                MainForm_Load(null, null);
            }
        }

        private void addButton4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                FruitForm ff = new FruitForm(FruitTypeForm.MODE.ADD, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), (string)dataGridView1.SelectedRows[0].Cells[1].Value);
                if(ff.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("添加水果成功");
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

                }
            }
        }
    }
}
