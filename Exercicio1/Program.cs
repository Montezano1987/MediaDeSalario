using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            var culturaBrasileira2 = new CultureInfo("pt-BR");

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", new CultureInfo("pt-BR")));
        }
    }
}
