using System;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Graus Celsius?");
            string stringCelsius = Console.ReadLine();
            int celsius = Convert.ToInt32(stringCelsius);
            int fahconveter = celsius + 32;
            Console.WriteLine(celsius + "º celsius é o mesmo que " + fahconveter + " fahrenheit!!!");
            Console.ReadLine();
        }
    }
}
