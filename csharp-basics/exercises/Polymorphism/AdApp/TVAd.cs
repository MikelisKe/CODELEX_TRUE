namespace AdApp
{
    public class TVAd : Advert
    {
        private int _fee;
        private int _seconds;
        private int _rate;
        private bool _peak;
        public TVAd(int fee, int seconds, int rate, bool peak) : base(fee)
        {
            _fee = fee;
            _seconds = seconds;
            _rate = rate;
            _peak = peak;
        }

        public new int Cost()
        {
            var cost = _seconds * _rate;
            if (_peak = true)
            {
                cost *= 2;
            }
            var result = base.Cost() + cost;

            return _fee = result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}