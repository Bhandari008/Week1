using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Ex
{
    sealed class Shape
    {
        public int length { set; get; }
    }
    public class Rectangle : Shape
    {
        // Inheriting the Sealed Class "Shape" show error
    }
}
