using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTry
{
    class Calculation
    {
        public void calc() {
            Console.WriteLine("this is default calc");
        }

        public void calc(int x, int y)
        {
            Console.WriteLine("Sum is "+ (x+y));
        }
        public void calc(double x, double y)
        {
            Console.WriteLine("difference is " + (x - y));
        }
        public int calc(int x, int y, int z)
        {
            return(x * y * z);
        }
    }
}
