
namespace Heranca
{
    public abstract class ContaRendimento : Conta
    {
        protected ContaRendimento()
        {
        }

        protected ContaRendimento(double depositoInicial) : base(depositoInicial)
        {
        }

        public double PorcentagemRendimento { get; set; }

        public void Render()
        {
            base.Saldo *= PorcentagemRendimento;
        }
    }
}
