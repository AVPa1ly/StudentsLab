using System;

namespace DesignPatterns.AbstractFactory.ConcreteDetails
{
    class SportsEngine : Engine
    {
        public SportsEngine(int cost = 100000, int weight = 300, Factory manufacturer = Factory.Porche, int volume = 3) : base(cost, weight, manufacturer, volume)
        {
        }

        public override void Start(Wheel wheel)
        {
            base.Start(wheel);
            wheel.Spin();
            if (wheel is SportsWheel)
            {
                Console.WriteLine("Whoa! Spinnig at its full potential!");
            }
            else
            {
                Console.WriteLine($"{typeof(SportsWheel).Name} would fit much better with this engine.");
            }
        }
    }
}
