using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numeroConta = 863452;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";
            conta2.agencia = 863;
            conta2.numeroConta = 863452;

            Console.WriteLine(conta == conta2);
            //o resultado é false pq se trata de tipos referência (guardam o endereço de memória onde se encontra o objeto) e 
            //não tipo valor

            conta = conta2; //estou informando que conta vai apontar para o mesmo endereço de memória de conta2;
            Console.WriteLine(conta == conta2); //vai dar true
            conta2.saldo = 300;
            Console.WriteLine("Saldo conta2: " + conta2.saldo);
            Console.WriteLine("Saldo conta: " + conta.saldo); //vai ser 300 tbm, pois aponta para o mesmo objeto que conta2 aponta

            if (conta2.saldo >= 100)
            {
                conta2.saldo -= 100;
            }
           
            Console.ReadLine();
        }
    }
}
