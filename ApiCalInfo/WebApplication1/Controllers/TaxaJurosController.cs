using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiInfoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private IRepository repository;

        public TaxaJurosController(IRepository repo) => repository = repo;
        [HttpGet]
        public IEnumerable<TaxaJuros> Get()
        {
            return repository.TaxaJuro;
        }
    }
}
