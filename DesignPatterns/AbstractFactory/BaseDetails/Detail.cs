namespace DesignPatterns.AbstractFactory
{
    enum Factory
    {
        Porche,
        BMW,
        Lada
    }

    abstract class Detail
    {
        public int Cost { get; private set; }
        public int Weight { get; private set; }

        public Factory Manufacturer { get; private set; }

        protected Detail(int cost, int weight, Factory manufacturer)
        {
            Cost = cost;
            Weight = weight;
            Manufacturer = manufacturer;
        }
    }
}
