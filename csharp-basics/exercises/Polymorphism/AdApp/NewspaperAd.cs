namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _rate = rate;
            _column = column;
        }

        public override int Cost()
        {
            var addCost = _rate * _column;
            var feee = base.Cost()+addCost;
            return feee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}