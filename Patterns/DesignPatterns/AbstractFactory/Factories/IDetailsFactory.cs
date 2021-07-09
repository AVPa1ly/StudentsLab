using DesignPatterns.AbstractFactory.BaseDetails;

namespace DesignPatterns.AbstractFactory
{
    public interface IDetailsFactory
    {
        Engine CreateEngine(int cost, int weight, Factory manufacturer, int volume);
        Suspension CreateSuspension(int cost, int weight, Factory manufacturer, int stiffness);
        Wheel CreateWheel(int cost, int weight, Factory manufacturer, int diameter);
    }
}
