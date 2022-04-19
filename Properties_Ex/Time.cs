using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Ex
{
    public class Time
    {
        private int _seconds;
        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }
        public decimal Minutes
        {
            get { return Seconds / 60; }
            set { Seconds = (int)value * 60; }

        }
        public decimal Hours
        {
            get { return Minutes / 60; }
            set { Minutes = value * 60; }
        }
    }
}
