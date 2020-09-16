using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalConsumer.Models
{
    public interface IRepository
    {
        decimal Calcular(decimal Values);
    }
}
