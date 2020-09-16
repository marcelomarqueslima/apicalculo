using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalConsumer.Models
{
    public class Repository : IRepository
    {
        private readonly Investment _investment;

        public Repository(Investment investment)
        {
            _investment = investment;
        }

        public string Calculation()
        {
            double valuesFinal = _investment.ValuesInit * Math.Pow(1 + _investment.Juros, _investment.Month);
            valuesFinal = Math.Truncate(100 * valuesFinal) / 100;

            if (valuesFinal > double.MaxValue)
            {
                throw new Exception("Valor superior a quantidade de casas decimais.");
            }

            return valuesFinal.ToString("Valor Final");
        }
    }
}
