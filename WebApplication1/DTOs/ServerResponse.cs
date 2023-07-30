using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTOs
{
    public class ServerResponse
    {
        public string Text { get; set; }
        public string PhoneNumber { get; set; }
        public string SessionId { get; set; }
        public string ServiceCode { get; set; }
    }
}