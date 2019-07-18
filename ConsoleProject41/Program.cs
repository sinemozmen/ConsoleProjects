using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaçıncı sayıya kadar kareleri görmek istersiniz.");
            int hedefKareler = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            Kareler f = new Kareler(hedefKareler);
            foreach(int n in f)
            {
                sayac++;
                Console.WriteLine(sayac + ".sayının karesi = " + n);
                System.Threading.Thread.Sleep(200);
            }
            Console.ReadKey();
        }
    }
    class Kareler : IEnumerable
    {
        private KareEnumerator iter;
        public Kareler(int max)
        {
            iter = new KareEnumerator(max);
        }
        public IEnumerator GetEnumerator()
        {
            return iter;
        }
    }
    class KareEnumerator : IEnumerator
    {
        private int currentNumber, maxNumber;
        public KareEnumerator(int max)
        {
            maxNumber = max;
            Reset();
        }
        public object Current
        {
            get
            {
                return currentNumber * currentNumber;
            }
        }
        public bool MoveNext()
        {
            ++currentNumber;
            return currentNumber <= maxNumber;
        }
        public void Reset()
        {
            currentNumber = 0;
        }
    }
}   
