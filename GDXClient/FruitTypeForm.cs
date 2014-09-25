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
        private int _id;
        private string _name;
        public FruitTypeForm(MODE mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        public FruitTypeForm(MODE mode, int id, string name)
        {
            InitializeComponent();
            this._mode = mode;
            this._id = id;
            this._name = name;
            this.name.Text = _name;
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name.Text.Trim()))
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                if(_mode == MODE.ADD)
                {
                    SysPublic.getInstance().getService().AddFruitType(name.Text, FruitType_callback);
                }
                else if (_mode == MODE.EDIT)
                {
                    SysPublic.getInstance().getService().UpdateFruitType(_id, name.Text, FruitType_callback);
                }
            }
        }

        private void FruitType_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
        {
            if(Result == 0)
            {
                MessageBox.Show("操作失败");
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
