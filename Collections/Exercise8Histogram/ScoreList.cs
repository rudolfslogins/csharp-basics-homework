using System.Collections.Generic;

namespace Exercise8Histogram
{
    public class ScoreList
    {
        private int _minValue;
        private int _maxValue;
        private string _totalScoreList = "";

        public ScoreList(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public string GetTotalScoreList
        {
            get { return _totalScoreList; }
        }
        public int MinValue
        {
            get { return _minValue; }
        }
        public int MaxValue
        {
            get { return _maxValue; }
        }

        public void AddScoreToList()
        {
            _totalScoreList += "*";
        }

    }
}