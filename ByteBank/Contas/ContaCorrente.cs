using ByteBank.Titular;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContas { get; private set; }
        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get { return this._numeroAgencia; }
            set
            {
                if (value > 0)
                    this._numeroAgencia = value;
            }
        }
        public string? Conta { get; set; }
        private double _saldo;


        public Cliente? Titular { get; set; }

        public ContaCorrente(Cliente cliente, int numeroAgencia, string numeroConta)
        {
            this.Titular = cliente;
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
        }

        public ContaCorrente()
        {
            TotalContas++;
        }

        public void ExiberDados()
        {
            Console.WriteLine($"\nTitular: {Titular.Nome}");
            Console.WriteLine($"Número da agencia: {NumeroAgencia}");
            Console.WriteLine($"Conta: {Conta}");
            Console.WriteLine($"Saldo: R${_saldo}\n");
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public bool Transferir(ContaCorrente destino, double valor)
        {
            if (_saldo < valor)
                return false;
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
                Console.WriteLine("Não é possível definir um saldo menor que zero!");
            else
                this._saldo += valor;
        }

        public double GetSaldo()
        {
            return this._saldo;
        }
    }
}
