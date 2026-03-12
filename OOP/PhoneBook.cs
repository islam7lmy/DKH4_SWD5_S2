using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct PhoneBook
    {
        long[] numbers;
        string[] names;
        int size;
        public int Size { get { return size; } }

        public PhoneBook(int _size)
        {
            size = _size;
            numbers = new long[size];
            names = new string[size];
        }

        public PhoneBook() : this(10)
        {
            //size = 10;
            //numbers = new long[size];
            //names = new string[size];
        }

        public void AddNumber(string _name, long _number, int _position)
        {
            if (_position >= 0 && _position < Size)
            {
                names[_position] = _name;
                numbers[_position] = _number;
            }
        }

        public long GetNumber(string _name)
        {
            int index = Array.IndexOf(names, _name);
            if (index >= 0)
                return numbers[index];
            return -1;
        }

        public void SetNumber(string _name, long _number)
        {
            int index = Array.IndexOf(names, _name);
            if (index >= 0)
                numbers[index] = _number;
        }

        // indexer : special property
        public long this[string _name]
        {
            get
            {
                int index = Array.IndexOf(names, _name);
                if (index >= 0)
                    return numbers[index];
                return -1;
            }
            set
            {
                int index = Array.IndexOf(names, _name);
                if (index >= 0)
                    numbers[index] = value;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < Size)
                    return $"{index} :: {names[index]} :: {numbers[index]}";
                else
                    return "Index is out of range";
            }
        }
    }
}
