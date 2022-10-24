using CashMachineDomain.Modelos;

namespace CashMachineDomain.Servicos.Interfaces
{
    public interface IServicoSaque
    {
        public Saque BuscaValorCedulas(int valor);
    }

}
