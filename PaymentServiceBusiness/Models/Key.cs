using System;
using PaymentServiceBusiness.Enums;

namespace PaymentServiceBusiness.Models
{
    public class Key
    {
        public Guid Id { get; set; }

        public EKeyType KeyType { get; set; }
        public string Description { get; set; }
    }
}
