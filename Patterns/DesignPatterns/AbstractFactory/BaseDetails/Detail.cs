namespace DesignPatterns.AbstractFactory.BaseDetails
{
    public abstract class Detail
    {
        public readonly int cost;
        public readonly int weight;
        public readonly Factory manufacturer;

        protected Detail(int cost, int weight, Factory manufacturer)
        {
            this.cost = cost;
            this.weight = weight;
            this.manufacturer = manufacturer;
        }
    }
}
