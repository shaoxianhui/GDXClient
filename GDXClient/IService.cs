using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GDXClient
{
    public interface IService
    {
        Hashtable Login(string name, string password);
    }
}
