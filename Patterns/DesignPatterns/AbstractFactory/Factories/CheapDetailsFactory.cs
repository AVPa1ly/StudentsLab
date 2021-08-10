using DesignPatterns.AbstractFactory.ConcreteDetails;
using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    public class CheapDetailsFactory : IDetailsFactory
    {
        public Engine CreateEngine(int cost, int weight, Factory manufacturer, int volume)
        {
            return new CheapEngine(cost, weight, manufacturer, volume);
        }

        public Suspension CreateSuspension(int cost, int weight, Factory manufacturer, int stiffness)
        {
            return new CheapSuspension(cost, weight, manufacturer, stiffness);
        }

        public Wheel CreateWheel(int cost, int weight, Factory manufacturer, int diameter)
        {
            return new CheapWheel(cost, weight, manufacturer, diameter);
        }
    }
}
