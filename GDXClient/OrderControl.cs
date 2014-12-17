using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using org.phprpc.util;

namespace GDXClient
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        public OrderControl(Hashtable order)
        {
            InitializeComponent();
            label1.Text += Encoding.UTF8.GetString((byte[])order["customer"]);
            label2.Text += Encoding.UTF8.GetString((byte[])order["earliest"]);
            label3.Text += Encoding.UTF8.GetString((byte[])order["latest"]);
            label4.Text += Encoding.UTF8.GetString((byte[])order["comment"]);
            label5.Text += Encoding.UTF8.GetString((byte[])order["status"]);
            Hashtable items = PHPConvert.ToHashtable(order["orderItems"]);
            if (items != null)
            {
                foreach (DictionaryEntry aa in items)
                {
                    Hashtable line = PHPConvert.ToHashtable(aa.Value);
                    dataGridView6.Rows.Insert(0, new object[] { Encoding.UTF8.GetString((byte[])line["id"]),
                                                        Encoding.UTF8.GetString((byte[])line["product"]),
                                                        Encoding.UTF8.GetString((byte[])line["quantity"]),
                                                        Encoding.UTF8.GetString((byte[])line["money"]),
                                                        Encoding.UTF8.GetString((byte[])line["comment"])});
                }
            }
        }
    }
}
