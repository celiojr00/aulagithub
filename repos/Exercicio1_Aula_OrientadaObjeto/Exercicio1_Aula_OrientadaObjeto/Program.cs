using System;
using System.Globalization;

namespace Exercicio1_Aula_OrientadaObjeto
{
    class Program
    {
        static void Main(String[] args)
        {
            /*Exercicio 1
             Fazer um programa para ler os dados de duas pessoas, 
            depois mostrar o nome da pessoa maisvelha.*/
            Console.WriteLine("Exercício 1");
            Console.WriteLine("");

            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            x.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o nome da segunda pessoa:");
            y.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + x.nome);
            }
            else if (x.idade == y.idade)
            {
                Console.WriteLine(x.nome + " e " + y.nome + " possuem a mesma idade.");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + y.nome);
            }

            /*Exercicio 2
             Fazer um programa para ler nome e salário de dois funcionários. 
            Depois, mostrar o salário médio dos funcionários.*/

            Console.WriteLine("");
            Console.WriteLine("================================================================");
            Console.WriteLine("");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("");

            Funcionario a, b;
            double media;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Digite o nome do prineiro funcionário: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do prineiro funcionário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            b.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a.salario + b.salario) / 2.0;
            Console.WriteLine("Salário médio é " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
