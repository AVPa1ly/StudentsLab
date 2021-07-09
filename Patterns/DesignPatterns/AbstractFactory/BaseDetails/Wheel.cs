using System;

namespace DesignPatterns.AbstractFactory.BaseDetails
{
    public abstract class Wheel : Detail
    {
        public readonly int diameter;

        public Wheel(
            int cost,
            int weight,
            Factory manufacturer,
            int diameter)
            : base(cost, weight, manufacturer)
        {
            this.diameter = diameter;
        }

        public virtual void Spin()
        {
            Console.WriteLine("You spin me right round, baby, right round.");
        }
    }
}
