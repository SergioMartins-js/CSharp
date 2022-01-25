using System;
using System.Globalization;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;


            Console.WriteLine("Hello World!");
            Console.WriteLine("_____Atividade 01_____");
            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", cujo preço é: $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é: $ " + preco2);
            Console.WriteLine("Registro: " + idade + "anos de idade, código: " + codigo + " e gênero: " + genero);
            Console.WriteLine($"Medida com oito casas decimais: {media:F8}");
            Console.WriteLine($"Arredondado: {media:F3}");
            Console.WriteLine("Com ponto: " + media.ToString("F3", CultureInfo.InvariantCulture) + "");


        }
    }
}
