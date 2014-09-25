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
    public partial class FruitPriceForm : Form
    {
        private FruitTypeForm.MODE _mode;
        private int _fruitId;
        private string _fruitName;

        public FruitPriceForm(FruitTypeForm.MODE mode, int fruitId, string fruitName)
        {
            InitializeComponent();
            this._mode = mode;
            this._fruitId = fruitId;
            this._fruitName = fruitName;
            this.fruitName.Text = _fruitName;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(minPrice.Text.Trim()) &&
                String.IsNullOrEmpty(maxPrice.Text.Trim()))
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                if (_mode == FruitTypeForm.MODE.ADD)
                {
                    SysPublic.getInstance().getService().addFruitPrice(_fruitId, (float)Convert.ToDouble(minPrice.Text.Trim()), (float)Convert.ToDouble(maxPrice.Text.Trim()), cdate.Text.Trim(), addFruitPrice_callback);
                }
                else if (_mode == FruitTypeForm.MODE.EDIT)
                {

                }
            }
        }

        private void addFruitPrice_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if (Result == 0)
            {
                MessageBox.Show("添加失败");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
