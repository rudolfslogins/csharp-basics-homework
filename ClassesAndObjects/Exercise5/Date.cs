using System;

namespace Exercise5
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;                                                   
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string DisplayDate()
        {
            string result = "";
            if (_day < 10)
            {
                result += "0" + Convert.ToString(_day) + "/";
            }
            else
            {
                result += Convert.ToString(_day) + "/";
            }
            if (_month < 10)
            {
                result += "0" + Convert.ToString(_month) + "/";
            }
            else
            {
                result += Convert.ToString(_month) + "/";
            }
            result += Convert.ToString(_year);

            return result;
        }
    }
}