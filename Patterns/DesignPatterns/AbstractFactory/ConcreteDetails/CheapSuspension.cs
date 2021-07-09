using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    public class CheapSuspension : Suspension
    {
        public CheapSuspension(
            int cost,
            int weight,
            Factory manufacturer,
            int stiffness)
            : base(cost, weight, manufacturer, stiffness)
        {
        }

        public override void Bounce()
        {
            base.Bounce();
            Console.WriteLine($"Hard times riding the {GetType().Name}.");
        }
    }
}
