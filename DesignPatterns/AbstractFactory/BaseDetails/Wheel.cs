using System;

namespace DesignPatterns.AbstractFactory
{
    abstract class Wheel : Detail
    {
        public int Diameter { get; private set; }

        public Wheel(int cost, int weight, Factory manufacturer, int diameter) : base(cost, weight, manufacturer)
        {
            Diameter = diameter;
        }

        public virtual void Spin()
        {
            Console.WriteLine("You spin me right round, baby, right round.");
        }
    }
}
