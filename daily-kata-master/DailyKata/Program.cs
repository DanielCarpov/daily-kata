using System;

namespace DailyKata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string ahaha = ";\n - 5; 8; 51; 43; -101 ";
            Console.WriteLine("Hi! I'm a CALCULATORю    " + ahaha);
            Console.WriteLine("Ъ ы Ъ    " + StringCalculatorKata.Calculate(ahaha));
            Console.ReadLine();
        }
    }
}
