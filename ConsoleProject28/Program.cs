using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//referansa eklenmezse hata verecektir.

namespace ConsoleProject28
{
    class Program
    {
        static void Main(string[] args)
        {

            // Girilen sayının faktöriyelini hesaplayan program

            SqlConnection scn = new SqlConnection();
            // classı kullanabilmek için using'e ve referansa kütüphanenin eklenmesi gerekir.
            //Referansa eklenmezse usinge eklendiğinde hata verir.
            //referansa eklenip usinge eklenmezse aşağıdaki gibi kullanılabilir :
            // System.Data.SqlClient.SqlConnection scn = new System.Data.SqlClient.SqlConnection();

            while (true)
            {
                int girilen;
                int carpim = 1;
                int i = 0;

                try
                {
                    Console.WriteLine("Kaç adet sayının faktöriyelini hesaplamak istersiniz");
                    girilen = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Hatalı giriş");
                    continue;
                }
                Console.WriteLine(0 + " sayısının faktöriyeli = " + 1);

                for (i = 1; i <= girilen; i++)
                {
                    carpim = carpim * i;
                    Console.WriteLine(i + " sayısının faktöriyeli = " + carpim);
                }
                Console.ReadLine();
            }
        }
    }
}
