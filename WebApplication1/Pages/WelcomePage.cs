using System;
using System.Text;

namespace WebApplication1.Pages
{
    public static class WelcomePage
    {
        public static string GetMenu()
        {
            try
            {       
                var registration = new StringBuilder();

                registration.Append("CON ");

                registration.AppendLine("Welcome to Green Park Self-Service(select any option by responding with a number)");

                registration.AppendLine("1. Self Service");

                registration.AppendLine("3. Exit");

                return registration.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var response = new StringBuilder();

                response.AppendLine("Something went wrong please try again");

                return response.ToString();
            }
        }


    }
}