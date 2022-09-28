using System;
using System.Globalization;

namespace Exercicio2_AulaOrientadaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00 , 10);

            p.Nome = "T";
           

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}