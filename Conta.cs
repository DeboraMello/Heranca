using System;
using System.Collections.Generic;

namespace Heranca
{
    public abstract class Conta : IConta
    {
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public double Saldo { get; protected set; }

        protected List<double> OperacoesEmConta;

        public Conta() { 
            GerarAgenciaNumero(); 
            OperacoesEmConta = new List<double>();
        }

        public Conta(double depositoInicial)
        {
            Saldo += depositoInicial;
            GerarAgenciaNumero();
            OperacoesEmConta = new List<double>();
        }

        private void GerarAgenciaNumero()
        {
            Agencia = (new Random()).Next().ToString();
            Numero = (new Random()).Next().ToString();
        }

        public virtual void Depositar(double valor)
        {
            Saldo = +valor;
            OperacoesEmConta.Add(valor);
        }

        public void Transferir(double valor, Conta conta)
        {
            Saldo -= valor;
            conta.Depositar(valor);
        }
    }
}
