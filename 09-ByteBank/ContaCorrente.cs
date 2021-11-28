using System;

namespace _09_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int NumeroConta { get; set; }
        private int _agencia;
        private double _saldo = 100;
        public static int TotalContasCriadas { get; private set; } //static pq é uma propriedade da classe, todos os objetos compartilham dessa informação
        public static double TaxaOperacao { get; private set; }

        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            NumeroConta = numero;
            TaxaOperacao = 30 / TotalContasCriadas;
            TotalContasCriadas++;
        }

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Não é possível inserir na agência um número negativo ou 0.");
                    return;
                }
                _agencia = value;
            }
        }

        public double Saldo //propriedade Saldo (não é método nem campo)
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

       
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}


   