using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int toplam = Int32.Parse(a) + Int32.Parse(b);
                Console.WriteLine(toplam);
            
            }
           
            catch(FormatException nesne)
            {
                Console.WriteLine("Şu hata meydana geldi-0: " + nesne.Message); // exception throw etmek 
            }
            catch (System.OverflowException nesne)//2.kez nesne yazabilirim ancak üstteki scope'ta işi bitiyor.
            {
                Console.WriteLine("Şu hata meydana geldi-1: " + nesne.Message); 
            }
            catch
            {
                Console.WriteLine("Şu hata meydana geldi-2: Nesnesiz catch" ); 
            }
            finally
            {
                Console.ReadLine();

            }
        }
    }
}
