namespace AdApp
{
    public class Poster: Advert
    {
        private int _fee;
        private int _costPerCopy;
        private int _numOfCopies;

        public Poster(int fee, int costPerCopy, int numOfCopies) : base(fee)
        {
            _fee = fee;
            _costPerCopy = costPerCopy;
            _numOfCopies=numOfCopies;
        }

        public new int Cost()
        {
            var addCost = _costPerCopy * _numOfCopies;
            var result = base.Cost() + addCost;
            return _fee = result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}