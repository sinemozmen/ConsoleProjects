using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject39
{
    class Program
    {
        static void Main(string[] args)
        {//Açılan parantez kadar kapanan parantezin olduğu en içteki parantezden başlayarak sayıların 
         //ters çevrildiği programı yazınız.

            Console.Write("Lütfen dizi giriniz.");
            string girilen = Console.ReadLine();
            char[] diziYap = girilen.ToCharArray();
            //object [] acmaIndex = new object[diziYap.Length];


            //object[] kapamaIndex = new object[diziYap.Length];
            //for(int i = 0; i< diziYap.Length; i++)
            //{
            //    acmaIndex[i] = Array.IndexOf(diziYap, '(');

            //}

            //Console.ReadLine();
            //int a = Array.IndexOf(diziYap, '(');
            //Console.WriteLine(a);
            //Console.ReadLine();


            //foreach (var item in liste)
            //{
            //    liste.Add(item);
            //    acmaIndex = liste.IndexOf('(');
            //    Console.WriteLine(acmaIndex[]);
            //    kapamaIndex[] = liste.IndexOf(')');
            //    Console.WriteLine(kapamaIndex[]);

            //}
            //Console.ReadLine();



            //ÇÖZÜM 2

            ArrayList liste = new ArrayList();
            foreach (var item in diziYap)
            {
                liste.Add(item);
            }
            int indexof;
            int lastIndexof;
            object tmp = "";
            object tmp2 = "";

            
                
                lastIndexof = liste.LastIndexOf('(');
                Console.WriteLine(lastIndexof);
                Console.ReadLine();
                indexof = liste.IndexOf(')');
                Console.WriteLine(indexof);
                Console.ReadLine();
                for(int i = lastIndexof; i<=indexof;indexof--)
                {
                    tmp = liste[lastIndexof + 1];
                    tmp2 = liste[indexof - 1];
                    liste[indexof - 1] = liste[lastIndexof + 1];
                    liste[lastIndexof + 1] = tmp2;

                    // liste[indexof - 1] = liste[lastIndexof + 1];
                    lastIndexof++;
                    indexof--;

                }
               
            foreach (var item in liste)
            {
                Console.Write(item);
            }

            Console.ReadLine();




        }
    }
}
