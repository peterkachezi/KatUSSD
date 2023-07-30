namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaypalPayment
    {
        public Guid Id { get; set; }

        public string TransactionId { get; set; }

        public string PayerId { get; set; }

        public string PayerFirstName { get; set; }

        public string PayerLastName { get; set; }

        public string PayerEmail { get; set; }

        public string PayerCountryCode { get; set; }

        public string Status { get; set; }

        public string Intent { get; set; }

        public string Cart { get; set; }

        public string RecipientCity { get; set; }

        public string RecipientCountryCode { get; set; }

        public string Line1 { get; set; }

        public string RecipientPostalCode { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public string MerchantId { get; set; }

        public string State { get; set; }

        public string PaymentMethod { get; set; }

        public string Currency { get; set; }

        public decimal? AmountPaid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TransactionDate { get; set; }
    }
}
