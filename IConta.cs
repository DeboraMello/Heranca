
namespace Heranca
{
    public interface IConta
    {
        void Depositar(double valor);

        void Transferir(double valor, Conta conta);
    }
}
