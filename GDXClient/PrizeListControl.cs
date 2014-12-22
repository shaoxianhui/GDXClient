using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.phprpc;
using org.phprpc.util;
using System.Collections;

namespace GDXClient
{
    public partial class PrizeListControl : UserControl
    {
        private int pageForPrize = 1;

        public PrizeListControl()
        {
            InitializeComponent();
        }

        private void first_Click(object sender, EventArgs e)
        {
            SysPublic.getInstance().getService().GetPrizer(1, getPrizeOfUser_callback);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (pageForPrize == 1)
                return;
            SysPublic.getInstance().getService().GetPrizer(--pageForPrize, getPrizeOfUser_callback);
        }

        private void next_Click(object sender, EventArgs e)
        {
            SysPublic.getInstance().getService().GetPrizer(++pageForPrize, getPrizeOfUser_callback);
        }

        private void updateReceived_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32((string)dataGridView4.SelectedRows[0].Cells[0].Value);
                int received = Convert.ToInt32((string)dataGridView4.SelectedRows[0].Cells[4].Value);
                SysPublic.getInstance().getService().UpdateReceived(id, received == 0 ? 1 : 0, updateReceived_callback);
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
                                                        line["phone"] == null ? "": Encoding.UTF8.GetString((byte[])line["phone"]),
                                                        Encoding.UTF8.GetString((byte[])line["content"]),
                                                        Encoding.UTF8.GetString((byte[])line["prizeName"]),
                                                        Encoding.UTF8.GetString((byte[])line["received"]),
                                                        String.Format("{0}", Util.UTCToDateTime(Convert.ToInt32(Encoding.UTF8.GetString((byte[])line["ctime"]))))});
            }
        }

        private void updateReceived_callback(int result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (result > 0)
            {
                MessageBox.Show("修改成功");
                SysPublic.getInstance().getService().GetPrizer(pageForPrize, getPrizeOfUser_callback);
            }
        }

        private void PrizeListControl_Load(object sender, EventArgs e)
        {
            first_Click(null, null);
        }
    }
}
