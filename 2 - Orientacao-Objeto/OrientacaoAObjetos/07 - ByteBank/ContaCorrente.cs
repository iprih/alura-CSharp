

namespace _07___ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int QtdContasCriadas { get; private set; } // pertence a classe 

        //public static int GetQtdCriadas()
        //{
        //    return QtdContasCriadas;
        //}



        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int Numero { get; set; }
        private double _saldo = 500; // campo privado que pode ser usado em uma propriedade ou nao

        public double Saldo //propriedade
        {
            get // get precisa ter retorno
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


        public void SetSaldo(double saldo) //argumento
        {
            if (saldo < 0)
            {

            }
            else
            {
                this._saldo = saldo;
            }
        }
        public double GetSaldo()
        {
            return _saldo;
        }


        public ContaCorrente(int agencia, int numero) //forma de construir regras
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.QtdContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

