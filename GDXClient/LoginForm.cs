using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using org.phprpc;

namespace GDXClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || password.Text == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }
            PHPRPC_Client client = new PHPRPC_Client("http://www.meirixianguo.com/index.php/Home/Api");
            try
            {
                IService service = (IService)client.UseService(typeof(IService));
                Hashtable admin = service.Login(name.Text.Trim(), password.Text.Trim());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
