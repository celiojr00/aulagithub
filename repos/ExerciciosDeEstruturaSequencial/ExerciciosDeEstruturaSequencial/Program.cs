using System;
using System.Globalization;

namespace ExercicioDeEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Parte 1 do Exercicio");
            Console.WriteLine("Digite o primeiro nro da soma:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo nro da soma:");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine();
            Console.WriteLine(soma);
            Console.WriteLine();
            Console.WriteLine("=========================================");
            */
            /*
            Console.WriteLine("Parte 2 do Exercicio ( Area=PI(3,14159).raio² ) ");
            Console.WriteLine("Digite o valor do raio:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(x, 2.0);

            Console.WriteLine();
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("=========================================");
           */
            Console.WriteLine("Parte 4 do Exercicio");
            Console.WriteLine("Digite o número de um funcionário:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada:");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = n2 * n3;
            Console.WriteLine("Numero do Funcionario: " + n1);
            Console.WriteLine("Total salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}