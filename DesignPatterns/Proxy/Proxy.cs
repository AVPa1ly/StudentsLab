using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class Proxy: IYesterdayRate
    {
        private IYesterdayRate service;
        private Dictionary<DateTime, int> cache;

        public Proxy(IYesterdayRate externalService, Dictionary<DateTime, int> externalCache)
        {
            service = externalService;
            cache = externalCache;
        }

        public int GetRate()
        {
            int rate = service.GetRate();
            cache.Add(DateTime.Now, rate);
            return rate;
        }
    }
}
