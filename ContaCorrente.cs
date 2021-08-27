using System;

namespace Heranca
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(){
            
        }
        public ContaCorrente(double depositoInicial) : base(depositoInicial)
        {
        }

        public void Sacar(double valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }

        }
    }
}
