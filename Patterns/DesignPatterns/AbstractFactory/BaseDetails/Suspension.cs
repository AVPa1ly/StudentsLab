using System;

namespace DesignPatterns.AbstractFactory.BaseDetails
{
    public abstract class Suspension : Detail
    {
        public readonly int stiffness;

        public Suspension(
            int cost,
            int weight,
            Factory manufacturer,
            int stiffness)
            : base(cost, weight, manufacturer)
        {
            this.stiffness = stiffness;
        }

        public virtual void Bounce()
        {
            Console.WriteLine("Hit some rough ground!");
            if (stiffness >= 5)
            {
                Console.WriteLine("Which wasn't really pleasing so far.");
            }
        }
    }
}
