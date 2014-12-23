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
    public partial class OrderListControl : UserControl
    {
        private DateTimePicker dtp;
        public OrderListControl()
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
            GetOrders();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            list.Controls.Clear();
            SysPublic.getInstance().getService().GetOrder(dtp.Value.ToString(dtp.CustomFormat).Trim(), getOrder_callback);
        }

        private void getOrder_callback(Hashtable result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result == null)
                return;
            foreach (DictionaryEntry order in result)
            {
                Hashtable line = PHPConvert.ToHashtable(order.Value);
                OrderControl oc = new OrderControl(line);
                oc.Dock = DockStyle.Top;
                list.Controls.Add(oc);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GetOrders();
        }
    }
}
