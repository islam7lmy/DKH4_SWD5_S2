using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal interface ISeries
    {
        public int Current { get; set; }
        void GetNext();
        void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }
    }

    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }
    }

    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
    }

    class SeriesByFive : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 5;
        }
    }


    class SeriesBySix : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 6;
        }
    }
}
