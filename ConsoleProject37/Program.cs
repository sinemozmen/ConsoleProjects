using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject37
{
    class Program
    {   /*Bir jet kasada para üstü sadece 2,5 ve 10 lira olarak verilebilmektedir.
          1-Exception,3-Exception , 4 = 2+2 , 5 = 5, 6= 2+2+2, 7 =5+2, 8 = 2+2+2+2, 9=5+2+2 ,10 = 10 tl 
          Amaç min sayıdaki banknot ile para üstünü vermektir.*/

        static void Main(string[] args)
        {
            int paraUstu = 0;
            int k = 0;
            int d = 0;
            int c = 0;
            int z = 0;

            while(true)
            {
                //Random rnd = new Random();
                //paraUstu = rnd.Next(1, 20);
                //Console.WriteLine("Random para üstü =" + paraUstu);
                //Console.ReadLine();
                try
                {
                    Console.WriteLine("Para üstünü giriniz.");
                    paraUstu = Convert.ToInt32(Console.ReadLine());

                    if (paraUstu % 10 == 0)
                    {
                        k = paraUstu / 10;
                        Console.WriteLine("Para üstü " + k + " adet 10 TL");
                    }
                    else
                    {
                        k = paraUstu / 10;// 155 lira için 15.5 k-int olduğu için 15 
                        if (k != 0)//8 için 0 tane 10 tl yazmasın 
                        { Console.Write("Para üstü " + k + " adet 10 TL , "); }
                        if (paraUstu % 2 == 0) //18 için 10+ kalan 8i bulsun
                        {
                            z = (paraUstu - 10*k) / 2;
                            Console.WriteLine("Para üstü " + z + " adet 2 TL");
                            continue;
                        }
                        if ((paraUstu - 10 * k) % 5 == 0)
                        {
                            d = (paraUstu - (10 * k)) / 5;
                            Console.Write(d + " adet 5 TL ");
                        }
                        else//157 için 150+5+2
                        {
                            d = (paraUstu - (10 * k)) / 5;//31.4 int -> 31
                            if (d != 0)
                            { Console.Write(d + " adet 5 TL , "); }

                            if ((paraUstu - (10 * k + 5 * d)) % 2 == 0)
                            {
                                c = (paraUstu - (10 * k + 5 * d)) / 2;
                                Console.Write(c + " adet 2 TL ");
                            }
                            else 
                            {
                                if (paraUstu == 3) 
                                {
                                    Console.WriteLine("Para üstü için kasada geçerli banknot yoktur.3 lira bağışlanacaktır.");
                                    continue;
                                }
                                c = (paraUstu - (10 * k + 5 * d)) / 2;
                                if (c != 0)
                                { Console.Write(c + " adet 2 TL "); }

                                if((paraUstu - (10*k+5*d+2*c))!= 0)
                                {
                                    Console.WriteLine("Para üstü için kasada geçerli banknot yoktur. Kalan " 
                                        + (paraUstu - (10 * k + 5 * d + 2 * c)) + " lira bağışlanacaktır.");
                                }
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Hatalı bir değer girdiniz.");
                }
            }
             //Console.ReadLine();
        }
    }
}
