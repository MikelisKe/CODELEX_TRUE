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

        private new int Cost()
        {
            var addCost = _rate * _column;
            var fee = base.Cost()+addCost;
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}