using CashMachineDomain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CashMachineDomain.Modelos;
using CashMachineDomain.BancoDeDados;
using CashMachineDomain.Excecoes;

namespace CashMachineDomain.Servicos
{
    public class ServicoSaque : IServicoSaque
    {
        private readonly INotas _notas;

        public ServicoSaque(INotas notas)
        {
           //this.notas = notas;
            _notas = notas;

        }

        public Saque BuscaValorCedulas(int valor)
        {
            if (valor <= 1 || valor == 3) throw new ExcecaoValorInvalido(valor);

            var cedulasDisponiveis = _notas.BuscaNotasDisponiveis().ToList().Where(c => c != 5);

            var saque = new Saque();
            if (valor % 2  == 1)
            {
                valor -= 5;
                saque.AdicionarCedula(5, 1);
            }
            foreach (int cedula in cedulasDisponiveis)
            {
                valor = ProcessaCedula(valor, saque, cedula);
            }

            return saque;
        }

        private static int ProcessaCedula(int valor, Saque saque, int cedula)
        {
            if ( valor >= cedula)
            {
                int quantidadeCedula = valor / cedula;
                valor %= cedula;

                saque.AdicionarCedula(cedula, quantidadeCedula);
            }
            return valor;
        }

    }
}
