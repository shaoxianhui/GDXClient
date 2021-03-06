﻿using System;
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
    public partial class FruitForm : Form
    {
        private FruitTypeForm.MODE _mode = FruitTypeForm.MODE.ADD;
        private int _fruitTypeId;
        private string _fruitTypeName;
        private int _id;
        private string _name;
        private int _level;
        private string _area;
        private string _unit;
        private string _description;
        private float _loss;
        public FruitForm(FruitTypeForm.MODE mode, int fruitTypeId, string fruitTypeName)
        {
            InitializeComponent();
            _mode = mode;
            _fruitTypeId = fruitTypeId;
            _fruitTypeName = fruitTypeName;
            this.fruitTypeName.Text = _fruitTypeName;
        }

        public FruitForm(FruitTypeForm.MODE mode, int id, string name, int level, string area, string unit, string description, float loss)
        {
            InitializeComponent();
            this._mode = mode;
            this._id = id;
            this._name = name;
            this._level = level;
            this._area = area;
            this._unit = unit;
            this._description = description;
            this._loss = loss;
            this.name.Text = _name;
            this.level.Text = _level.ToString();
            this.area.Text = _area;
            this.unit.Text = _unit;
            this.description.Text = _description;
            this.loss.Text = _loss.ToString();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text.Trim()) &&
                String.IsNullOrEmpty(level.Text.Trim()) &&
                String.IsNullOrEmpty(area.Text.Trim()) &&
                String.IsNullOrEmpty(unit.Text.Trim()) &&
                String.IsNullOrEmpty(description.Text.Trim()) &&
                String.IsNullOrEmpty(loss.Text.Trim()))
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                if (_mode == FruitTypeForm.MODE.ADD)
                {
                    SysPublic.getInstance().getService().AddFruit(_fruitTypeId, name.Text.Trim(), Convert.ToInt32(level.Text.Trim()), area.Text.Trim(), unit.Text.Trim(), description.Text.Trim(), (float)Convert.ToDouble(loss.Text.Trim()), Fruit_callback);
                }
                else if (_mode == FruitTypeForm.MODE.EDIT)
                {
                    SysPublic.getInstance().getService().UpdateFruit(_id, name.Text, Convert.ToInt32(level.Text.Trim()), area.Text.Trim(), unit.Text.Trim(), description.Text.Trim(), (float)Convert.ToDouble(loss.Text.Trim()), Fruit_callback);
                }
            }
        }

        private void Fruit_callback(int Result, object[] args, string output, PHPRPC_Error error, bool failure)
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
    }
}
