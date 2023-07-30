using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ServerResponse
    {
        public string text { get; set; }
        public string phoneNumber { get; set; }
        public string sessionId { get; set; }
        public string serviceCode { get; set; }
    }
}