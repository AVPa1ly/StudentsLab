using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    public class CheapWheel : Wheel
    {
        public CheapWheel(
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
            Console.WriteLine($"A ruined {GetType().Name}.");
        }
    }
}
