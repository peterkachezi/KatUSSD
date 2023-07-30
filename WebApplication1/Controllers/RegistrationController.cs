using System.Net.Http;
using System.Net;
using System.Text;
using System;
using System.Web.Http;
using WebApplication1.Models;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [RoutePrefix("api/registration")]
    public class RegistrationController : ApiController
    {
        [Route("home")]
        // specify the actual route, your url will look like... localhost:8080/api/mobile/ussd...
        [HttpPost]
        // state that the method you intend to create is a POST
        public async Task<HttpResponseMessage> Home([FromBody] ServerResponse serverResponse)
        {
            // declare a complex type as input parameter
            HttpResponseMessage rs;
            string response;
            if (serverResponse.text == null)
            {
                serverResponse.text = "";
            }

            // loop through the server's text value to determine the next cause of action
            if (serverResponse.text.Equals("", StringComparison.Ordinal))
            {
                // always include a 'CON' in your first statements
                response = "CON This is AfricasTalking \n";
                                response += "1. Get your phone number";
            }
            else if (serverResponse.text.Equals("1", StringComparison.Ordinal))
            {
                response = "END Your phone number is " + serverResponse.phoneNumber;

                //the last response starts with an 'END' so that the server understands that it's the final response
            }
            else
            {
                response = "END invalid option";
            }
            rs = Request.CreateResponse(HttpStatusCode.Created, response);

            // append your response to the HttpResponseMessage and set content type to text/plain, exactly what the server expects
            rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");
            // finally return your response to the server
            return rs;

        }
    }
}
