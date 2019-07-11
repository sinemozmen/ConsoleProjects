using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleproject31
{
    class program
    {
        static void Main(string[] args)
        {

            int sayi1 = 4;
            int sayi2 = 6;
            //int snc1 = sayi1++ + sayi2;//i++= postincrement
            //Console.WriteLine("sayi1 = " + sayi1);
            //Console.WriteLine("sayi2 = " + sayi2);
            //Console.WriteLine("snc1 = " + snc1);
            //Console.ReadLine();


            //int snc2 = ++sayi1 + sayi2;///i++= preincrement
            //Console.WriteLine("sayi1 = " + sayi1);
            //Console.WriteLine("sayi2 = " + sayi2);
            //Console.WriteLine("snc2 = " + snc2);
            //Console.ReadLine();

            //int snc3 = ++sayi1 + sayi2++;
            //Console.WriteLine("sayi1 = " + sayi1);
            //Console.WriteLine("sayi2 = " + sayi2);
            //Console.WriteLine("snc3 = " + snc3);
            //Console.ReadLine();



            //int snc4 = ++sayi1 + sayi2++ + sayi1; //5+6+5
            //Console.WriteLine("sayi1 = " + sayi1);//5
            //Console.WriteLine("sayi2 = " + sayi2);//7
            //Console.WriteLine("snc4 = " + snc4);
            //Console.ReadLine();
            //4,6
            int snc5 = ++sayi1 + sayi2++ + ++sayi1 + ++sayi1 + ++sayi2;//5+6+6+7+8
            Console.WriteLine("sayi1 = " + sayi1);//7
            Console.WriteLine("sayi2 = " + sayi2);//8
            Console.WriteLine("snc5 = " + snc5);
            Console.WriteLine("sayi2 = " + sayi2);
            Console.WriteLine("snc5 = " + snc5);
            Console.ReadLine();


        }

    }
}
