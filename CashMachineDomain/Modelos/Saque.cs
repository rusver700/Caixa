using System.Collections.Generic;
using System.Linq;

namespace CashMachineDomain.Modelos
{
    public class Saque
    {
        public Saque()
        {
            _cedulas = new List<CedulaSaque>();
        }

        public int ValorTotal { get; private set; }
        private List<CedulaSaque> _cedulas { get; set; }
        public List<CedulaSaque> Cedulas => _cedulas.OrderByDescending(c => c.Cedula).ToList();
        public void AdicionarCedula(int cedula, int quantidade)
        {
            if (quantidade <= 0) return;

            ValorTotal += cedula * quantidade;
            var cedulaSaque = new CedulaSaque(cedula, quantidade);
            _cedulas.Add(cedulaSaque);

        }
    }
}
