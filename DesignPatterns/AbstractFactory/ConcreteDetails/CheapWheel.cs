using System;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class CheapWheel : Wheel
    {
        public CheapWheel(int cost = 200, int weight = 10, Factory manufacturer = Factory.Lada, int diameter = 15) : base(cost, weight, manufacturer, diameter)
        {
        }

        public override void Spin()
        {
            base.Spin();
            Console.WriteLine($"A ruined {GetType().Name}.");
        }
    }
}
