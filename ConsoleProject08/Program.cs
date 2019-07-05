using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject08
{
    class Program
    {
        static void Main(string[] args)
        {// Usage of TRY and CATCH
                int aInt = 0;
                int bInt = 0;
                try
                {
                    string a = Console.ReadLine();
                    aInt = Int32.Parse(a);
                }
                catch (FormatException nesne)
                {
                    Console.WriteLine(" Şu hata meydana geldi-0:" + nesne.Message);
                    Console.ReadLine();
                    return;
                }
                catch (OverflowException nesne)
                {
                    Console.WriteLine("; Şu hata meydana geldi-1: " +nesne.Message);
                    Console.ReadLine();
                    return;
                }
                catch
                {
                    Console.WriteLine("Şu hata meydana geldi-2: : NESNESİZ CATCH");
                    Console.ReadLine();
                    return;
                }
                try
                {
                    string b = Console.ReadLine();
                    bInt = Int32.Parse(b);
                }
                catch (FormatException nesne)
                {
                    Console.WriteLine(" Şu hata meydana geldi-0:" +nesne.Message);
                    Console.ReadLine();
                    return;
                }
                catch (OverflowException nesne)
                {
                    Console.WriteLine("; Şu hata meydana geldi-1: " +nesne.Message);
                    Console.ReadLine();
                    return;
                }
                catch
                {
                    Console.WriteLine(" Şu hata meydana geldi-2: : NESNESİZ CATCH");

                    Console.ReadLine();
                    return;
                }
                int toplam = aInt + bInt;
                Console.WriteLine(toplam);
                Console.ReadLine();


            
        }//main 
    }//class
}//namespace
    
