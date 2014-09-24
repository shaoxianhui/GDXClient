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
using Hprose.Client;

namespace GDXClient
{
    public partial class LoginForm : Form
    {
        private void login_callback(Boolean result, Object[] args, String output, PHPRPC_Error error, Boolean failure)
        {
            if (failure)
            {
                MessageBox.Show("登录失败！");
            }
            else
            {
                if (result == true)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
        }

        private void login_callback2(Boolean result, Object[] args)
        {
            if (result == true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

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
            IService service = (IService)client.UseService(typeof(IService));
            service.Login(name.Text.Trim(), password.Text.Trim(), login_callback);
            //HproseHttpClient client = new HproseHttpClient("http://www.meirixianguo.com/index.php/Home/Api2");
            //IService2 stub = client.UseService<IService2>();
            //stub.test1("World", login_callback2);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
