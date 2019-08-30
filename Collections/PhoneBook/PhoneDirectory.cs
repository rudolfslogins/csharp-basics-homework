using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<int,PhoneEntry> _data;
        private int _dataCount;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<int, PhoneEntry>();
            _dataCount = 0;
        }

        public string GetName(int position)
        {
            return _data[position].name;
        }

        public int GetLength()
        {
            return _data.Count;
        }
        private int Find(string name)
        {

            for (var i = 0; i < _dataCount; i++)
            {
                if (_data[i].name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            if (position == -1)
            {
                return null;
            }

            return _data[position].number;
            
        }

        public string PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            var i = Find(name);
            if (i >= 0)
            {
                _data[i].number = number;
                return "updated";
            }
            else
            {
                var newEntry = new PhoneEntry { name = name, number = number }; // Create a new pair.
                _data.Add(_dataCount,newEntry);   // Add the new pair to the array.
                _dataCount++;
                return "created";
            }
        }
    }
}