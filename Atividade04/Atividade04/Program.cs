using System;

namespace Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conta; 
            string titular;
            int dep = 0;
            int deptwo = 0;
            int saque = 0;
            int tot = 0;
            string dini;
            Console.Write("Entre com o número da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            titular = Console.ReadLine();
            Console.Write("Deseja reaizar deposito inicial? (S/N): ");
            dini = Console.ReadLine();

            if (dini == "S" || dini == "s")
            {
                Console.Write("Valor do deposito inicial: ");
                dep = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + dep);
                Console.Write("Entre com valor para deposito: ");
                deptwo = int.Parse(Console.ReadLine());
                int total = deptwo + dep;
                Console.WriteLine("Dados bancarios atualizados:\nDados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + total);
                Console.Write("Entre com valor para saque: ");
                saque = int.Parse(Console.ReadLine());
                tot = (total - saque) - 5;
                Console.WriteLine("Dados bancarios atualizados:\nDados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + tot);

            }
            else
            {
            Console.WriteLine("Dados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + dep);
            Console.Write("Entre com valor para deposito: ");
            deptwo = int.Parse(Console.ReadLine());
            int total = deptwo + dep;
            Console.WriteLine("Dados bancarios atualizados:\nDados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + total);
            Console.Write("Entre com valor para saque: ");
            saque = int.Parse(Console.ReadLine());
            tot = (total - saque) - 5;
            Console.WriteLine("Dados bancarios atualizados:\nDados da conta:\nConta: " + conta + ", Titular: " + titular + ", Saldo: " + tot);

            }

        }
    }
}
