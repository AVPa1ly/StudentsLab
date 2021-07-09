using DesignPatterns.AbstractFactory.BaseDetails;
using DesignPatterns.AbstractFactory.ConcreteDetails;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    public class SportsDetailsFactory : IDetailsFactory
    {
        public Engine CreateEngine(int cost, int weight, Factory manufacturer, int volume)
        {
            return new SportsEngine(cost, weight, manufacturer, volume);
        }

        public Suspension CreateSuspension(int cost, int weight, Factory manufacturer, int stiffness)
        {
            return new SportsSuspension(cost, weight, manufacturer, stiffness);
        }

        public Wheel CreateWheel(int cost, int weight, Factory manufacturer, int diameter)
        {
            return new SportsWheel(cost, weight, manufacturer, diameter);
        }
    }
}
