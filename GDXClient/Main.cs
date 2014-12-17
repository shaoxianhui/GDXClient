using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDXClient
{
    public partial class Main : Form
    {
        private System.Drawing.Point _mousePosition;
        private HashMap<string, UserControl> _controls = new HashMap<string,UserControl>();
        public Main()
        {
            InitializeComponent();
            _controls.Add("order_list", new OrderListControl());
            _controls.Add("order_edit", new OrderEditControl());
            _controls.Add("customer_edit", new CustomerEditControl());
            _controls.Add("fruit_edit", new FruitEditControl());
            _controls.Add("prize_list", new PrizeListControl());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void title_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this._mousePosition.X = e.X;
                this._mousePosition.Y = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - _mousePosition.Y;
                this.Left = Control.MousePosition.X - _mousePosition.X;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            work.Controls.Clear();
            string key = (sender as ToolStripMenuItem).Name;
            if (_controls.Keys.Contains(key))
            {
                UserControl uc = _controls[key];
                uc.Dock = DockStyle.Fill;
                work.Controls.Add(uc);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            OrderListControl ol = new OrderListControl();
            ol.Dock = DockStyle.Fill;
            work.Controls.Add(ol);
        }
    }
}
