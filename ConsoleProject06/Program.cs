using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject06
{
    class Program
    {
        static void Main(string[] args)
        { // Analyzing the below code snippet and learning how ConsoleKeyInfo class works by debugging 

            string _val = "";// initialize etmiş 
            Console.Write("Enter your value: ");
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true); // True girildiğinde ilk değeri göstermeyecek.ConsoleKeyInfo adındaki sınıfa atar.
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            Console.WriteLine("The Value You entered is : " + _val);
            Console.ReadKey();
        }

    }
}
