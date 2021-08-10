using System;

namespace DesignPatterns.AbstractFactory.BaseDetails
{
    public abstract class Engine : Detail
    {
        public readonly int volume;

        public Engine(
            int cost,
            int weight,
            Factory manufacturer,
            int volume)
            : base(cost, weight, manufacturer)
        {
            this.volume = volume;
        }

        public virtual void Start(Wheel wheel)
        {
            Console.WriteLine($"Starting a V{volume} engine to spin a {wheel.diameter}-inch wheel.");
            wheel.Spin();
        }
    }
}
