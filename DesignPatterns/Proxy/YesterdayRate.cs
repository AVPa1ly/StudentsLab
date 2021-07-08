using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class YesterdayRate : IYesterdayRate
    {
        private int rate;

        public YesterdayRate(int value)
        {
            rate = value;
        }
        public int GetRate()
        {
            return rate;
        }
    }
}
