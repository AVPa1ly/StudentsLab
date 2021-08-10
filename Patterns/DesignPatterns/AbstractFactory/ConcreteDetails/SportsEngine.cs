using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    public class SportsEngine : Engine
    {
        public SportsEngine(
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
            if (wheel is SportsWheel)
            {
                Console.WriteLine("Whoa! Spinnig at its full potential!");
            }
            else
            {
                Console.WriteLine($"{typeof(SportsWheel).Name} would fit much better with this engine.");
            }
        }
    }
}
