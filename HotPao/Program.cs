using System;

namespace HotPao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá HotPão!");
            Console.WriteLine("Quantos pães foram vendidos hoje?");
            string stringPaes = Console.ReadLine();
            Console.WriteLine("Quantas broas foram vendidos hoje?");
            string stringBroas = Console.ReadLine();

            double paes = Convert.ToDouble(stringPaes);
            double broas = Convert.ToDouble(stringBroas);

            double paesTotal = paes * 0.12;
            double broasTotal = broas * 1.50;
            double totalDia = paesTotal + broasTotal;


            Console.WriteLine("Pães: R$" + paesTotal);
            Console.WriteLine("Broas: R$" + broasTotal);
            Console.WriteLine("Total: R$" + totalDia);
            double poupança = totalDia * 0.10;
            Console.WriteLine("Guardar poupança: R$" + poupança);
            Console.ReadLine();

        }
    }
}
