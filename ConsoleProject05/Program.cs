using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: " + sizeof(int) + "byte yer kaplar. Max: " + int.MaxValue + " Min : " + int.MinValue);
            Console.WriteLine("");
            Console.WriteLine("Size of double: " + sizeof(double) + "byte yer kaplar. Max: " + double.MaxValue + " Min : " + double.MinValue);
            Console.WriteLine("");
            Console.ReadLine();

            //char a = 'h';// char tek tırnak(') ile gösterilir.String " ile gösterilir.

        }
    }
}
