namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaybillPayment
    {
        public int Id { get; set; }

        public string TransactionType { get; set; }

        public string TransID { get; set; }

        public string TransTime { get; set; }

        public string TransAmount { get; set; }

        public string BusinessShortCode { get; set; }

        public string BillRefNumber { get; set; }

        public string InvoiceNumber { get; set; }

        public string OrgAccountBalance { get; set; }

        public string ThirdPartyTransID { get; set; }

        public string MSISDN { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
    }
}
