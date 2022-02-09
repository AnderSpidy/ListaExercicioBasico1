using System;

namespace ListaExercicioBasico1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Imobiliária Imóbilis!!!");
            Console.WriteLine("Digite a Largura do Terreno:");
            string strlargura = Console.ReadLine();
            Console.WriteLine("Digite o Comprimento do Terreno:");
            string strcomprimento = Console.ReadLine();

            double largura = Convert.ToDouble(strlargura);
            double comprimento = Convert.ToDouble(strcomprimento);

            Console.WriteLine("------------------------");
            double resultado = largura * comprimento;
            Console.WriteLine("A área do terreno é de " + resultado);
        }
    }
}
