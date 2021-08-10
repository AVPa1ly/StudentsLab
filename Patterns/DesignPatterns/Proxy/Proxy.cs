using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Proxy: IYesterdayRate
    {
        private readonly IYesterdayRate service;
        private readonly Dictionary<DateTime, int> cache;

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
