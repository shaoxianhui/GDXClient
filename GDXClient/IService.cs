using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using org.phprpc;

namespace GDXClient
{
    public interface IService
    {
        void Login(string name, string password, PHPRPC_Callback<Boolean> callback);
    }
}
