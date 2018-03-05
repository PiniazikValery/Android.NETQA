using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMarket.TestFramework.Filters
{
    public class HiddenAttribute : Attribute
    {
        public string Name = "Hidden";

        string attributInfo = "Element is hidden";

        public string GetInfo()
        {
            return attributInfo;
        }
    }
}
