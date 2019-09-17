namespace AdApp
{
    public class Poster : Advert
    {
        private double _widthDimension;
        private double _heightDimension;
        private int _numOfCopies;
        private int _costPerCopy;

        public Poster(int fee, double xDim, double yDim, int copies, int copyCost) : base(fee)
        {
            _widthDimension = xDim;
            _heightDimension = yDim;
            _numOfCopies = copies;
            _costPerCopy = copyCost;
        }

        public override int Cost()
        {
            int costSizeIncreaseIndex = _widthDimension * _heightDimension < 1000 ? 1 : 2;
            return base.Cost() + _numOfCopies * (int)_costPerCopy * costSizeIncreaseIndex;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Poster: Copies= {_numOfCopies} Cost of copy: {_costPerCopy} Advert cost: {Cost()}";
        }

    }
}