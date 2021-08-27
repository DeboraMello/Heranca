
namespace Heranca
{
    public class ContaPoupanca : ContaRendimento
    {
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(double depositoInicial, double bonus) : base(depositoInicial)
        {
            base.Saldo += bonus;
        }
    }
}
