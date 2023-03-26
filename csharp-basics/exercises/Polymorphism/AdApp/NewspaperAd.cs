namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _fee;
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _fee = fee;
            _column = column;
            _rate = rate;
        }

        private new int Cost()
        {
            var cost = _column * _rate;
            var result = base.Cost() + cost;
            return _fee = result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}