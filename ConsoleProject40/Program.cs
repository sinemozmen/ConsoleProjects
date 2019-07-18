using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject40
{
    class Program
    {
        static void Main(string[] args)
        {   //Fibonacci numbers oluşturma projemizi FibonacciNumbers class'ı oluşturarak çözelim 
            //Yani FibonacciNumbers class'ı ekranda girilen sayıya kadar olan FibonacciNumber'ları 
            //bizim için de foreach ile gezebileceğimiz bir collection'a çevirsin.
            Console.WriteLine("Lütfen ulaşmak istediğiniz Fibonacci sayısını giriniz.");
            int hedeffibonacciSayisi = Convert.ToInt32(Console.ReadLine());
            FibonacciNumbers f = new FibonacciNumbers(hedeffibonacciSayisi);
            foreach (int n in f)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
    class FibonacciNumbers : IEnumerable
    {
        private FibonacciEnumerator iter;
        public FibonacciNumbers(int max)
        {
            iter = new FibonacciEnumerator(max);
        }

        public IEnumerator GetEnumerator()
        {
            return iter;
        }

    }
    class FibonacciEnumerator : IEnumerator
    {
        private int currentNumber, nextNumber, maxNumber;

        public FibonacciEnumerator(int max)
        {
            maxNumber = max;
            Reset();

        }
        public object Current
        {
            get
            {
                return currentNumber;
            }
        }
        public bool MoveNext()
        {
            int newNextNumber = currentNumber + nextNumber;
            currentNumber = nextNumber;
            nextNumber = newNextNumber;
            return currentNumber <= maxNumber;//MoveNext true olduğu sürece dönecek.

        }
        public void Reset()
        {
            currentNumber = 0;
            nextNumber = 1;
        }
    }
}
