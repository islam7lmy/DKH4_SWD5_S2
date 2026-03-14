using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int Size
        {
            get { return size; }
            set
            { 
                //if (size == 0)
                //{
                //    size = value <= 0 ? 10 : value;
                //}
                //else 
                if (value > size)
                {
                    long[] newnumbers = new long[value];
                    string[] newnames = new string[value];

                    numbers?.CopyTo(newnumbers, 0);
                    names?.CopyTo(newnames, 0);

                    numbers = newnumbers;
                    names = newnames;

                    size = value <= 0 ? 10 : value;
                }
                else if (value < size)
                {
                    int maxindexhasdata = Array.IndexOf(names, null);
                    if (maxindexhasdata >= 0 && value >= maxindexhasdata)
                    {
                        long[] newnumbers = new long[value];
                        string[] newnames = new string[value];

                        for (int i = 0; i < maxindexhasdata; i++)
                        {
                            newnumbers[i] = numbers[i];
                            newnames[i] = names[i];
                        }

                        numbers = newnumbers;
                        names = newnames;
                        size = value <= 0 ? 10 : value;
                    }
                } 
            }
        }

        public PhoneBook(int _size)
        {
            Size = _size;
            numbers = new long[Size];
            names = new string[Size];
        }

        //constructor chaining
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
