using System;

namespace DesignPatterns.AbstractFactory
{
    abstract class Engine : Detail
    {
        public int Volume { get; set; }

        public Engine(int cost, int weight, Factory manufacturer, int volume) : base(cost, weight, manufacturer)
        {
            Volume = volume;
        }

        public virtual void Start(Wheel wheel)
        {
            Console.WriteLine($"Starting a V{Volume} engine to spin a {wheel.Diameter}-inch wheel.");
        }
    }
}
