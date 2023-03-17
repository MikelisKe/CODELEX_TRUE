namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
        }

        public new int Cost()
        {
            var addCost = _numDays * _rate;
            return base.Cost() + addCost;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}