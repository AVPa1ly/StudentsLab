using DesignPatterns.AbstractFactory.ConcreteDetails;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    class SportsDetailsFactory : IDetailsFactory
    {
        public Engine CreateEngine()
        {
            return new SportsEngine();
        }

        public Suspension CreateSuspension()
        {
            return new SportsSuspension();
        }

        public Wheel CreateWheel()
        {
            return new SportsWheel();
        }
    }
}
