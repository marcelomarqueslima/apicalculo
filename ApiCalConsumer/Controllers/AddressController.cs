using ApiCalConsumer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalConsumer.Controllers
{
    /// <summary>
    /// Classe de apontamento do projeto API Calculo
    /// </summary>
    [Route("api/showmethecode")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly Address _address;

        public AddressController(Address address)
        {
            _address = address;
        }

        /// <summary>
        /// Get responsavel para o endereço do projeto API Calculo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { SouceCode = _address.UrlProjeto });
        }
    }
}
