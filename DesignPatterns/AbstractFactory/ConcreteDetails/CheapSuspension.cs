using System;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class CheapSuspension : Suspension
    {
        public CheapSuspension(int cost = 1000, int weight = 20, Factory manufacturer = Factory.Lada, int stiffness = 15) : base(cost, weight, manufacturer, stiffness)
        {
        }

        public override void Bounce()
        {
            base.Bounce();
            Console.WriteLine($"Hard times riding the {GetType().Name}.");
        }
    }
}
