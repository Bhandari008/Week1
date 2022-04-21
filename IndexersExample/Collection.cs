using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersExample
{
    public class Collection
    {
        private string[] _collection = new string[10];
        // indexer property
        public string this[int idx]
        {
            get
            {
                if (idx > 9)
                {
                    Console.WriteLine("Index out of range");
                    return "";
                }
                return _collection[idx];
            }
            set
            {
                if(idx>9)
                {
                    Console.WriteLine("Index out of range");
                }
                _collection[idx] = value;
            }
        }
    }
}
