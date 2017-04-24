using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Print(int a)
        {
            Console.WriteLine(a * a);
        }
        static void Print(double a)
        {
            Console.WriteLine(a + a);
        }
        static void Main(string[] args)
        { 
                Print(3);
            Console.Read();
            
        }
    }
}
