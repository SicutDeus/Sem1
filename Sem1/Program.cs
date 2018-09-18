using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = (1 + Math.Sqrt(5)) / 2;
            string str = Console.ReadLine();
            double n;
           double.TryParse(str, out n);
            n = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
