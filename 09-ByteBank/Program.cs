using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro.");   
            }
           

            Console.ReadLine();
        }


        //OUTROS MÉTODOS
        private static void Metodo()
        {
             TestaDivisao(0);
        }


        private static void TestaDivisao(int divisor)
        {
            try{
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + "é " + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine("Não é possível fazer uma divisão por 0.");
            }
        }


        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo); Nesse caso ocorre uma exceção, pois a variável conta que não aponta para
            //nenhum objeto, tenta acessar o atributo Saldo de um objeto que não existe ;p

            return numero / divisor;
        }
    }
}
