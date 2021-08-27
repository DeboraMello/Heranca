using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente(20);
            var contaNova = TransformaConta<ContaCorrente,ContaInvestimento>(conta1);
            Console.WriteLine($"A sua conta inicial é do tipo {conta1.GetType().Name} e foi convertida para o tipo {contaNova.GetType().Name}!"); 
            
        }

        public static B TransformaConta<A, B>(A oldConta) where A : Conta where B : Conta 
        { 
            var newConta = Activator.CreateInstance<B>(); 
            oldConta.Transferir(oldConta.Saldo, newConta); 
            oldConta = null;
            return newConta; 
        } 
    }
}