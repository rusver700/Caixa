using System;
using CashMachineDomain.BancoDeDados;

namespace CashMachineLB
{
    public class BancoDeNotas : INotas
    {
        public int[] BuscaNotasDisponiveis()
        {
            return new int[] { 200, 100, 50, 20, 10, 5, 2 };

        }
    }
}
