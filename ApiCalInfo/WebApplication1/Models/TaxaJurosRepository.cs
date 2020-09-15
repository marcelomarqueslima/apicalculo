using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TaxaJurosRepository
    {
        private Dictionary<int, TaxaJuros> items;

        public TaxaJurosRepository()
        {
            items = new Dictionary<int, TaxaJuros>();

            new List<TaxaJuros>
            {
                new TaxaJuros{Id=1, Juros=0.1}
            }.ForEach(r => AddTaxaJuros(r));
        }

        public IEnumerable<TaxaJuros> TaxaJuros => items.Values;

        public TaxaJuros AddTaxaJuros(TaxaJuros r)
        {
            if(r.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key))
                {
                    key++;
                }
                r.Id = key;
            }
            items[r.Id] = r;
            return r;
        }
    }
}
