using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GDXClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm lf = new LoginForm();
            try
            {
                if (lf.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
