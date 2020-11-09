using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.model;

namespace TCP_Server
{
    class DataSet
    {
        //List of data
        public static readonly List<FanOutput> FanData = new List<FanOutput>()
        {
            new FanOutput(1, "Fan Fanner", 20, 33),
            new FanOutput(2, "Fan Tastic", 24, 55),
            new FanOutput(3, "Fan Nominal", 22, 44),
            new FanOutput(4, "Fan T You", 17, 45),
            new FanOutput(5, "Fan 3000", 19, 59)
        };
    }
}
