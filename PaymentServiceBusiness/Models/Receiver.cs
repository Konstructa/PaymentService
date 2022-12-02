using System;

namespace PaymentServiceBusiness.Models
{
    public class Receiver
    {
        public Guid Id { get; set; }
        public Key Key { get; set; }
        public string Name { get; set; }
    }
}
