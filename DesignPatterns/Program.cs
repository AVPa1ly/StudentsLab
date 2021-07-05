using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient[] clients = { new AbstractFactory.Client(), new Adapter.Client() };
            foreach (IClient client in  clients)
            {
                Console.WriteLine(client.GetType().Namespace);
                client.ShowPattern();
            }
        }
    }
}
