using Microsoft.Extensions.DependencyInjection;
using CashMachineDomain.BancoDeDados;
using CashMachineDomain.Servicos.Interfaces;
using CashMachineLB;
using CashMachineDomain.Servicos;
using System;

namespace CashMachineIoC
{
    public class IoC
    {
        public static void ConfigurarDependencias(IServiceCollection servicos)
        {
            servicos.AddScoped<INotas, BancoDeNotas>();
            servicos.AddScoped<IServicoSaque, ServicoSaque>();
        }
    }
}
