using System;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class SportsSuspension : Suspension
    {
        public SportsSuspension(
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
            Console.WriteLine($"Riding the {GetType().Name} feels so enjoyable.");
        }
    }
}
