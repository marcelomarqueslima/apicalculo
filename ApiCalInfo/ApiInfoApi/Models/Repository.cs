using System;
using System.Collections.Generic;

namespace ApiInfoApi.Models
{
    public class Repository : IRepository
    {
        private List<TaxaJuros> juros = new List<TaxaJuros>();
        private int _nextId = 1;

        public Repository()
        {
            AddReserva(new TaxaJuros { Id = 1, Juros = 0.01 });
        }

        public TaxaJuros AddReserva(TaxaJuros item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            juros.Add(item);
            return item;
        }

        public IEnumerable<TaxaJuros> GetAll()
        {
            return juros;
        }
    }
}
