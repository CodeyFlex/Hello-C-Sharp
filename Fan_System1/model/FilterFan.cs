using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.model
{
    public class FilterFan
    {
        public int LowTemp { get; set; }

        public int HighTemp { get; set; }

        public FilterFan(int lowTemp, int highTemp)
        {
            LowTemp = lowTemp;
            HighTemp = highTemp;
        }

        public FilterFan()
        {
        }
    }
}
