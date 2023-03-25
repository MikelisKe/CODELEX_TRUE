namespace AdApp
{
    public class Poster: Advert
    {
        private int _costPerCopy;
        private int _numOfCopies;

        public Poster(int fee, int costPerCopy, int numOfCopies) : base(fee)
        {
            _costPerCopy = costPerCopy;
            _numOfCopies=numOfCopies;
        }

        public new int Cost()
        {
            var addCost = _costPerCopy * _numOfCopies;
            return base.Cost() +addCost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}