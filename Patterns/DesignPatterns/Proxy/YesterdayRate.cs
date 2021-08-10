namespace DesignPatterns.Proxy
{
    public class YesterdayRate : IYesterdayRate
    {
        private readonly int rate;

        public YesterdayRate(int value)
        {
            rate = value;
        }
        public int GetRate()
        {
            return rate;
        }
    }
}
