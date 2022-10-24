namespace CashMachineDomain.Modelos
{
    public class CedulaSaque
    {
        public CedulaSaque(int cedula, int quantidade)
        {
            Cedula = cedula;
            Quantidade = quantidade;
        }

        public object Cedula { get; internal set; }
        public object Quantidade { get; internal set; }

    }
}
