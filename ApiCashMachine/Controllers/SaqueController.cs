using CashMachineDomain.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CashMachineDomain.Excecoes;
using CashMachineDomain.BancoDeDados;

namespace ApiCashMachine.Controllers
{
    [ApiController]
    [Route("v1/caixa")]
    public class SaqueController : ControllerBase
    {
        private readonly IServicoSaque _servicoSaque;
        private readonly INotas _notas;
        public SaqueController(IServicoSaque servicoSaque, INotas bancoDeNotas)
        {
            _servicoSaque = servicoSaque;
            _notas = bancoDeNotas;
        }
    
        [HttpGet("fazer-saque")]
            
        public IActionResult CedulasSaquePorValor(int valorSaque)
        {
            try
            {
                var retornoCedulas = _servicoSaque.BuscaValorCedulas(valorSaque);
                return Ok(retornoCedulas);
            }
            catch (ExcecaoValorInvalido ex)
            {
                return UnprocessableEntity(ex.Message);
            }
        }
  
        [HttpGet("buscar-cedulas-disponiveis")]
        public IActionResult CedulasDisponiveis()
        {
            var retornaCedula = _notas.BuscaNotasDisponiveis();
               return Ok(retornaCedula);

        }
      
        [HttpGet("test")]
        public IActionResult Test()
        {
          return Ok();
        }
      
        [HttpPost("testPost")]
        public IActionResult TestPost()
        {
            return Ok();
        }

        [HttpDelete("testDelete")]
        public IActionResult TestDelete()
        {
            return Ok();
        }
        [HttpGet("testGetok")]
        public IActionResult TestGetok()
        {
            return Ok();
        }
        //////////V2///////////
    }
}
