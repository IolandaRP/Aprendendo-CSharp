
namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }


        public int agencia;
        public int numeroConta;
        private double _saldo = 100;


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

        /*public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double saldo)
        {
           if (saldo < 0)
           {
                return;
           }
                _saldo = saldo;
        }*/


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


   