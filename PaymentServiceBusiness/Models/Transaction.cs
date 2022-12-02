using System;

namespace PaymentServiceBusiness.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public Payer Payer { get; set; }
        public int PayerId { get; set; }
        public Receiver Receiver { get; set; }
        public int ReceiverId { get; set; }
    }
}
