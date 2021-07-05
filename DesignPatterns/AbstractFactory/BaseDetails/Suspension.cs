using System;

namespace DesignPatterns.AbstractFactory
{
    abstract class Suspension : Detail
    {
        public int Stiffness { get; private set; }

        public Suspension(int cost, int weight, Factory manufacturer, int stiffness) : base(cost, weight, manufacturer)
        {
            Stiffness = stiffness;
        }

        public virtual void Bounce()
        {
            Console.WriteLine("Hit some rough ground!");
            if (Stiffness >= 5)
            {
                Console.WriteLine("Which wasn't really pleasing so far.");
            }
        }
    }
}
