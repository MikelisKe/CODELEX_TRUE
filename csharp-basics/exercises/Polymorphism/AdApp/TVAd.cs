namespace AdApp
{
    public class TVAd: Advert
    {
        private int _sec;
        private int _rate;
        private bool _peakTime;
        public TVAd(int fee, int sec, int rate, bool peakTime) : base(fee)
        {
            _sec=sec;
            _rate=rate;
            _peakTime=true;
        }
        
        public new int Cost() 
        {
            var addCost = _peakTime ==true ? 2* _sec*_rate : _sec *_rate;
            return base.Cost()+ addCost;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}