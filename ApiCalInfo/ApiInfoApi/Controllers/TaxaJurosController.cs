using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiInfoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiInfoApi.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        static readonly IRepository repositorio = new Repository();
        public IEnumerable<TaxaJuros> GetAllJuros()
        {
            return repositorio.GetAll();
        }
    }
}
