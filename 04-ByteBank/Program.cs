using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Bruno";
            bool resultadoSaque = conta.Sacar(50);

            Console.WriteLine("Saldo da conta: " + conta.saldo);
            Console.WriteLine(resultadoSaque);
            conta.Depositar(500);
            Console.WriteLine("Saldo da conta " + conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";
            Console.WriteLine("Saldo da conta2: " + conta2.saldo);

            conta.Transferir(200, conta2);
            Console.WriteLine("Saldo da conta: " + conta.saldo);
            Console.WriteLine("Saldo da conta2: " + conta2.saldo);

            Console.ReadLine();
        }
    }
}
