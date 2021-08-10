using System;
using DesignPatterns.AbstractFactory.BaseDetails;
using DesignPatterns.AbstractFactory.ConcreteFactories;

namespace DesignPatterns.AbstractFactory
{
    class Client: IClient
    {
        private Engine engine;
        private Wheel wheel;
        private Suspension suspension;
        private IDetailsFactory factory;

        public void ShowPattern()
        {
            IDetailsFactory[] factories = { new SportsDetailsFactory(), new CheapDetailsFactory() };
            foreach (var factory in factories)
            {
                CreateDetails(factory);
                DisplayLaunchDetails();
                Console.WriteLine();
            }
        }

        private void CreateDetails(IDetailsFactory custormFactory)
        {
            factory = custormFactory;
            Random rand = new Random();
            engine = factory.CreateEngine(rand.Next(2000, 40000), rand.Next(100, 150), (Factory)rand.Next(0,2), rand.Next(1, 3));
            wheel = factory.CreateWheel(rand.Next(300, 1700), rand.Next(9, 25), (Factory)rand.Next(0, 2), rand.Next(10, 15));
            suspension = factory.CreateSuspension(rand.Next(500, 12000), rand.Next(15, 30), (Factory)rand.Next(0, 2), rand.Next(1, 9));
        }

        private void DisplayLaunchDetails()
        {
            Console.WriteLine($"--Details created by {factory.GetType().Name}--");
            engine.Start(wheel);
            suspension.Bounce();
        }
    }
}
