using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ApiCalConsumer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalConsumer.Controllers
{
    [Route("api/calculajuros/{valuesinit}/{month}")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        decimal juros = 0;

        public static decimal Juros()
        {
            string url = $"https://localhost:44332/taxaJuros";

            var requisicao = WebRequest.Create(url);

            // Pega o stream com o contendo retornado pelo servidor.
            var response = (HttpWebResponse)requisicao.GetResponse();
            var dataStream = response.GetResponseStream();

            // Abre o stream usando o StreamReader.
            var juros = new StreamReader(dataStream);

            // Lê o conteudo para retornar o que aconteceu.
            return juros.Read();
        }

        public async Task<string> CalculationAsync(decimal valuesInit, int month, int juros)
        {
            

            Investment invest = new Investment(Convert.ToDouble(valuesInit), month, juros);

            IRepository calculo = new Repository(invest);
            return calculo.Calculation();
        }

    }
}
