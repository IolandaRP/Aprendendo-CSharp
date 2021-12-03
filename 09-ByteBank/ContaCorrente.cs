using System;

namespace _09_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private int NumeroConta { get; }
        public int Agencia { get; }
        private double _saldo = 100;
        public static int TotalContasCriadas { get; private set; } //static pq é uma propriedade da classe, todos os objetos compartilham dessa informação
        public static double TaxaOperacao { get; private set; }

        public ContaCorrente (int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            NumeroConta = numero;
            //TaxaOperacao = 30 / TotalContasCriadas;
            TotalContasCriadas++;
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

       
        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                _saldo -= valor;
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


   