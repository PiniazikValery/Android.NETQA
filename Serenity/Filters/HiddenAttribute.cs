using System;

namespace Framework.Filters
{
    public class HiddenAttribute:Attribute
    {
        public string Name = "Hidden";

        string attributInfo = "Element is hidden";

        public string GetInfo()
        {
            return attributInfo;
        }
    }
}
