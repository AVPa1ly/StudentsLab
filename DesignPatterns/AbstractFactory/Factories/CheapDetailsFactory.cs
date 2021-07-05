using DesignPatterns.AbstractFactory.ConcreteDetails;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    class CheapDetailsFactory : IDetailsFactory
    {
        public Engine CreateEngine()
        {
            return new CheapEngine();
        }

        public Suspension CreateSuspension()
        {
            return new CheapSuspension();
        }

        public Wheel CreateWheel()
        {
            return new CheapWheel();
        }
    }
}
