using System;

namespace DiasDeVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer " + nome);
            Console.WriteLine("Quntos anos voce tem?");
            string stringIdade = Console.ReadLine();
            int idade = Convert.ToInt32(stringIdade);
            int diasDeVida = idade * 365;
            Console.WriteLine("Sabia que voce já viveu " + diasDeVida + " dias em toda a sua vida?");
            Console.ReadLine();
        }
    }
}
