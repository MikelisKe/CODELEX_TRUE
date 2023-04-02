namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _fee { get; set; }
        private int _rate { get; set; }
        private int _numDays { get; set; }

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            _fee = fee;
            _rate = rate;
            _numDays = numDays;
        }

        public new int Cost()
        {
            var result = (_rate * _numDays)+ base.Cost();
            return _fee = result;
        }
    }
}