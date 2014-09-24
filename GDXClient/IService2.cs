using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hprose.Common;
using System.Threading.Tasks;
using System.Collections;

namespace GDXClient
{
    public interface IService2
    {
        [SimpleMode(true)]
        void login(string name, string password, HproseCallback<Boolean> callback);
    }
}
