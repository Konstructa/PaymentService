using System;
using System.Collections.Generic;

namespace PaymentServiceBusiness.Models
{
    public class Payer
    {
        public Guid Id { get; set; }
        public Key Key { get; set; }
        public string Name { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
