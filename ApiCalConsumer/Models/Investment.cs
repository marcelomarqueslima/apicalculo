using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalConsumer.Models
{
    public class Investment : Notifiable
    {
        public Investment(double valuesInit, int month, double juros)
        {
            ValuesInit = valuesInit;
            Month = month;
            Juros = juros;

            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, ValuesInit, "Investment.ValuesInit", "O valor inicial não pode ser zero.")
                .IsLowerOrEqualsThan(0, Month, "Investment.Month", "O valor mês não pode ser zero.")
                .IsGreaterOrEqualsThan(Month, ValuesInit, "Investment.ValuesInit", "O valor não pode ser menor que zero.")
                );
        }
        public double ValuesInit { get; set; }
        public int Month { get; set; }
        public double Juros { get; set; }
    }
}
