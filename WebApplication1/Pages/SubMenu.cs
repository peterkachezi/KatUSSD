using System;
using System.Text;

namespace WebApplication1.Pages
{
    public static class SubMenu
    {
        public static string GetMenu()
        {
            try
            {
                var registration = new StringBuilder();

                registration.Append("CON ");

                registration.AppendLine("Main Menu");

                registration.AppendLine("1. Parking Slots");                

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