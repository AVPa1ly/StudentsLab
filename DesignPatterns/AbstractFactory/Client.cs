using System;
using DesignPatterns.AbstractFactory.ConcreteFactories;

namespace DesignPatterns.AbstractFactory
{
    class Client: IClient
    {
        private static Engine engine;
        private static Wheel wheel;
        private static Suspension suspension;
        private static IDetailsFactory factory;

        public void ShowPattern()
        {
            IDetailsFactory[] factories = { new SportsDetailsFactory(), new CheapDetailsFactory() };
            foreach (var factory in factories)
            {
                CreateDetails(factory);
                DisplayLaunchDetails();
            }
        }

        private static void CreateDetails(IDetailsFactory custormFactory)
        {
            factory = custormFactory;
            engine = factory.CreateEngine();
            wheel = factory.CreateWheel();
            suspension = factory.CreateSuspension();
        }

        private static void DisplayLaunchDetails()
        {
            Console.WriteLine($"--Details created by {factory.GetType().Name}--");
            engine.Start(wheel);
            suspension.Bounce();
            Console.WriteLine();
        }
    }
}
