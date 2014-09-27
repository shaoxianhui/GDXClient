using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDXClient
{
    class Util
    {
        public static DateTime UTCToDateTime(int seconds)
        {
            DateTime dtZone = new DateTime(1970, 1, 1, 0, 0, 0);
            dtZone = dtZone.AddSeconds(seconds);
            return dtZone.ToLocalTime();
        }
    }
}
