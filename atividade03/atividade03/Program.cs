using System;

namespace atividade03
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora soma = new Calculadora();


            Console.WriteLine("----------Calculadora----------");
            Console.Write("Digite um número: ");
            soma.A = int.Parse(Console.ReadLine());
            Console.WriteLine("1-Para Soma\n2-Para Subtração\n3-Para multiplicação\n4-Para Multiplicação\n");
            Console.Write("Digite a Operação: ");
            string op = (Console.ReadLine());
            Console.Write("Digite outro número: ");
            soma.B = int.Parse(Console.ReadLine());

            
            if (op == "1")
            {
                Console.WriteLine("Resultado: " + soma.Soma());
            }
            else if (op == "2")
            {
                Console.WriteLine("Resultado: " + soma.Sub());
            }
            else if (op == "3")
            {
                Console.WriteLine("Resultado: " + soma.Mult());
            }
            else if (op == "4")
            {
                Console.WriteLine("Resultado: " + soma.Div());
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }



        }
    }
}
