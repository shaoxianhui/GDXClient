using System;
using System.Collections;
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
    public partial class FruitTypeForm : Form
    {
        public enum MODE { ADD, EDIT };
        private MODE _mode = MODE.ADD;
        public FruitTypeForm(MODE mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name.Text.Trim()))
            {
                MessageBox.Show("");
            }
            else
            {
                if(_mode == MODE.ADD)
                {
                    SysPublic.getInstance().getService().addFruitType(name.Text, addFruitType_callback);
                }
                else if (_mode == MODE.EDIT)
                {

                }
            }
        }

        private void addFruitType_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if(Result == 0)
            {
                MessageBox.Show("添加失败");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
