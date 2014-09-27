using org.phprpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDXClient
{
    class SysPublic
    {
        private static SysPublic _instance = new SysPublic();
        private PHPRPC_Client client = null;
        private IService service = null;

        private SysPublic()
        {
            //client = new PHPRPC_Client("http://localhost/guodaxia/index.php/Home/Api");
            client = new PHPRPC_Client("http://www.meirixianguo.com/index.php/Home/Api");
            service = (IService)client.UseService(typeof(IService));
        }

        public static SysPublic getInstance()
        {
            return _instance;
        }

        public IService getService()
        {
            return service;
        }
    }
}
