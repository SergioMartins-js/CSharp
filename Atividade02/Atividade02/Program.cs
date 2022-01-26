using System;
using System.Globalization;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Atividade 02");
            Console.Write("Entre com seu nome: ");
            string a = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Quantos Quartos tem na sua casa: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Entre com o preço de um produto: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Atividade vet");
            Console.Write("Digite cor, idade, altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int quarto = int.Parse(vet[1]);
            double preco = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Resultados: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
