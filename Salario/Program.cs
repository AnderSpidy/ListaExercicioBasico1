using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario do funcionario:");
            string stringSalario = Console.ReadLine();
            double Salario = Convert.ToDouble(stringSalario);
            Console.WriteLine("O salario inicial do funcionario é de R$" + Salario);
            double aumentoSalario = Salario + (Salario * 0.15);
            Console.WriteLine("O salario com aumento é de R$" + aumentoSalario);
            double salarioFinal = aumentoSalario - (aumentoSalario * 0.08);
            Console.WriteLine("O salrio final é de R$" + salarioFinal);
            Console.ReadLine();

        }
    }
}
