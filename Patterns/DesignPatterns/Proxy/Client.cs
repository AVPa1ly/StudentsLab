using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Proxy
{
    public class Client : IClient
    {
        public void ShowPattern()
        {
            IYesterdayRate service = new YesterdayRate(100);
            Console.WriteLine("Service class output: {0}", service.GetRate());

            Dictionary<DateTime, int> cache = new Dictionary<DateTime, int>();
            IYesterdayRate proxy = new Proxy(service, cache);
            for (int i = 0; i < 5; i++)
            {
                proxy.GetRate();
                Thread.Sleep(100);
            }

            Console.Write("Cached output via Proxy class: ");
            foreach (var item in cache)
            {
                Console.Write("<{0} -> {1}>; ", item.Key.Ticks, item.Value);
            }
        }
    }
}
