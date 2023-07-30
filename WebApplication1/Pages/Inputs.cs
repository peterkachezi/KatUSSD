using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApplication1.Pages
{
    public static class Inputs
    {
        public static string EnterName()
        {
            try
            {
                var sb = new StringBuilder();

                sb.Append("CON ");

                sb.AppendLine("Enter your full name");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var response = new StringBuilder();

                response.AppendLine("Something went wrong please try again");

                return response.ToString();
            }
        }
        public static string EnterPhoneNo()
        {
            try
            {
                var sb = new StringBuilder();

                sb.Append("CON ");

                sb.AppendLine("Enter Phone Number");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var response = new StringBuilder();

                response.AppendLine("Something went wrong please try again");

                return response.ToString();
            }
        }

        public static string EnterCareRegNo()
        {
            try
            {
                var sb = new StringBuilder();

                sb.Append("CON ");

                sb.AppendLine("Enter car registration no");

                return sb.ToString();
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