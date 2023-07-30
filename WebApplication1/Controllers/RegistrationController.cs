using System.Net.Http;
using System.Net;
using System.Text;
using System;
using System.Web.Http;
using System.Threading.Tasks;
using WebApplication1.Pages;
using System.Linq;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers
{

    [RoutePrefix("api/registration")]
    public class RegistrationController : ApiController
    {
        [Route("home")]
        // specify the actual route, your url will look like... localhost:8080/api/mobile/ussd...
        [HttpPost]
        // state that the method you intend to create is a POST
        public HttpResponseMessage Home([FromBody] ServerResponse serverResponse)
        {
            // declare a complex type as input parameter

            BookingDTO bookingDTO = new BookingDTO();

            HttpResponseMessage rs;

            string response;

            if (serverResponse.Text == null)
            {
                response = WelcomePage.GetMenu();

                rs = Request.CreateResponse(HttpStatusCode.Created, response);

                rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                return rs;
            }

            if (serverResponse.Text.StartsWith("1"))
            {
                if (serverResponse.Text.Equals("1", StringComparison.Ordinal))
                {
                    response = SubMenu.GetMenu();

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

                string[] splitString = serverResponse.Text.Split('*');

                int step = splitString.Count();

                if (step == 2)
                {
                    response = ParkingSlots.GetSlots();

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

                if (step == 3)
                {
                    response = Inputs.EnterName();

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

                if (step == 4)
                {
                    response = Inputs.EnterPhoneNo();

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

                if (step == 5)
                {
                    response = Inputs.EnterCareRegNo();

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

                if (step == 6)
                {
                    bookingDTO.CustomerName = splitString[1];

                    bookingDTO.PhoneNumber = splitString[2];

                    response = SlotBooking.Create(bookingDTO);

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs = Request.CreateResponse(HttpStatusCode.Created, response);

                    rs.Content = new StringContent(response, Encoding.UTF8, "text/plain");

                    return rs;
                }

            }



            // loop through the server's text value to determine the next cause of action
            if (serverResponse.Text.Equals("", StringComparison.Ordinal))
            {
                // always include a 'CON' in your first statements
                response = "CON This is AfricasTalking \n";
                response += "1. Get your phone number";
            }
            else if (serverResponse.Text.Equals("1", StringComparison.Ordinal))
            {
                response = "END Your phone number is " + serverResponse.PhoneNumber;

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
