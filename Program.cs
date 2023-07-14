using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            int result1 = c1.Sqaure(2);
            Console.WriteLine(result1);

            int result2 = c1.multiply(2, 3);
            Console.WriteLine(result2);

             double res = c1.Divide(2, 3);
            Console.WriteLine(res);
        }
    }
}
