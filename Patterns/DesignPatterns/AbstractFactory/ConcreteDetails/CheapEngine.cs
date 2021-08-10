using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    public class CheapEngine : Engine
    {
        public CheapEngine(
            int cost,
            int weight,
            Factory manufacturer,
            int volume)
            : base(cost, weight, manufacturer, volume)
        {
        }

        public override void Start(Wheel wheel)
        {
            base.Start(wheel);
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
