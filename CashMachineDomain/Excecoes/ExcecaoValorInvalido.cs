using System;

namespace CashMachineDomain.Excecoes
{
    public class ExcecaoValorInvalido : Exception
    {
        public ExcecaoValorInvalido(int valor) : base($"Valor inválido! Seu valor deve ser maior que 1 e diferente de 3, seu valor é {valor}.") { }
    }
}
