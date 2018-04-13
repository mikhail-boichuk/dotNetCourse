using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{
    class AttractionSettings
    {

        public static int GetBatmanPrice()
        {
            return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["BatmanPrice"]);
        }
        public static int GetSwanPrice()
        {
            return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SwanPrice"]);
        }
        public static int GetPonyPrice()
        {
            return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["PonyPrice"]);
        }

    }
}
