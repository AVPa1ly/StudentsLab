using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            const string splitter = "------------------------------";
            IClient[] clients = { new AbstractFactory.Client(), new Adapter.Client() };
            foreach (IClient client in  clients)
            {
                Console.WriteLine(splitter);
                Console.WriteLine(client.GetType().Namespace);
                client.ShowPattern();
            }
        }
    }
}
