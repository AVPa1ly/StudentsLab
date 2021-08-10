using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class SportsWheel : Wheel
    {
        public SportsWheel(
            int cost,
            int weight,
            Factory manufacturer,
            int diameter)
            : base(cost, weight, manufacturer, diameter)
        {
        }

        public override void Spin()
        {
            base.Spin();
            Console.WriteLine($"A shining {GetType().Name}.");
        }
    }
}
