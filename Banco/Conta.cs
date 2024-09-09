
namespace Banco
{
    public class Conta
    {
        private int _numero;
        private string _titular;
        private double _saldo;

        public Conta(int numero, string titular)
        {
            _numero = numero;
            _titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial)
        {
            _numero = numero;
            _titular = titular;
            Depositar(depositoInicial);
        }

        public int Numero
        {
            get { return _numero; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
        }

        public void Depositar(double quantia)
        {
            _saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            _saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                   + _numero
                   + ", Titular: "
                   + _titular
                   + ", Saldo: R$ "
                   + _saldo.ToString("F2");
        }
    }
}
