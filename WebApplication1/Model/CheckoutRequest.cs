namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CheckoutRequest
    {
        public int Id { get; set; }

        [Required]
        public string MerchantRequestID { get; set; }

        [Required]
        public string CheckoutRequestID { get; set; }

        [Required]
        public string ResponseCode { get; set; }

        [Required]
        public string ResponseDescription { get; set; }

        [Required]
        public string CustomerMessage { get; set; }
    }
}
