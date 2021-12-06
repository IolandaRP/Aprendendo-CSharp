using System;

namespace _09_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private int NumeroConta { get; }
        public int Agencia { get; }
        private double _saldo = 100;
        public static int TotalContasCriadas { get; private set; } 
        public static double TaxaOperacao { get; private set; }
        public int SaquesNaoPermitidos { get; private set; }
        public int TransferenciasNaoPermitidas { get; private set; }

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
            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
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
            if (valor < 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que 0.", nameof(valor));
            }
            if (_saldo < valor)
            {
                SaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
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


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor da transferência deve ser maior que 0.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                TransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Transferência não realizada.", ex);
;            }
               
            contaDestino.Depositar(valor);
        }

    }
}


   