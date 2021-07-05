using System;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class CheapEngine : Engine
    {
        public CheapEngine(int cost = 5000, int weight = 100, Factory manufacturer = Factory.Lada, int volume = 1) : base(cost, weight, manufacturer, volume)
        {
        }

        public override void Start(Wheel wheel)
        {
            base.Start(wheel);
            wheel.Spin();
            if (wheel is CheapWheel)
            {
                Console.WriteLine("Seems like it didn't cost you too much.");
            }
            else
            {
                Console.WriteLine($"{typeof(SportsWheel).Name} is unmatchable with this engine.");
            }
        }
    }
}
