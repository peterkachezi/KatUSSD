using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Pages
{
    public static class ParkingSlots
    {

        public static string GetSlots()
        {

            var cp = new StringBuilder();

            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var data = context.ParkingSlots.AsNoTracking().Where(x => x.IsBooked == false).Take(5).ToList();

                    int i = 0;

                    cp.Append("CON Available Slots \n ");

                    foreach (var item in data)
                    {
                        cp.AppendLine("" + ++i + "." + item.Name);

                    }
                    cp.AppendLine("0.Back");

                    return cp.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public static string GetSlots1()
        {
            try
            {
                var registration = new StringBuilder();

                registration.Append("CON ");

                registration.AppendLine("Available Slots");

                registration.AppendLine("1. B12");
                registration.AppendLine("2. B13");
                registration.AppendLine("2. B14");


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