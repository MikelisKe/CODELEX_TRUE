using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string,string> _data;
        private int _dataCount;

        public PhoneDirectory(string Name, string Number)
        {
            _data = new SortedDictionary<string, string>();
            _data.Add(Name, Number);
            _dataCount = 0;
        }

        private string Find(string name)
        {
            foreach (var v in _data)
            {
                if (name == v.Key)
                {
                    return v.Value;
                }
            }
            Console.WriteLine($"No {name} in there");
            return null;
        }

        public string GetNumber(string name)
        {
            return Find(name);
        }

            public void PutNumber(string name, string number)
            {
            if (_data.ContainsKey(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
                _dataCount++;
            }
        }
    }
}