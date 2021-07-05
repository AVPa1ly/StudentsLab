using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class SportsSuspension : Suspension
    {
        public SportsSuspension(int cost = 9000, int weight = 25, Factory manufacturer = Factory.Porche, int stiffness = 4) : base(cost, weight, manufacturer, stiffness)
        {
        }

        public override void Bounce()
        {
            base.Bounce();
            Console.WriteLine($"Riding the {GetType()} feels so enjoyable.");
        }
    }
}
