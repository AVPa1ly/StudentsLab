using System;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class SportsWheel : Wheel
    {
        public SportsWheel(int cost = 3000, int weight = 14, Factory manufacturer = Factory.Porche, int diameter = 20) : base(cost, weight, manufacturer, diameter)
        {
        }

        public override void Spin()
        {
            base.Spin();
            Console.WriteLine($"A shining {GetType().Name}.");
        }
    }
}
