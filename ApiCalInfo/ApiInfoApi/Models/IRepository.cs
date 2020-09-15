using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInfoApi.Models
{
   public interface IRepository
    {
        IEnumerable<TaxaJuros> GetAll();
        TaxaJuros AddReserva(TaxaJuros juro);
    }
}
