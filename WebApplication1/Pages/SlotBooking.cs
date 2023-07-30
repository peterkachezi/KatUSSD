using System;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DTOs;

namespace WebApplication1.Pages
{
    public static class SlotBooking
    {
        public static string Create(BookingDTO bookingDTO)
        {
            try
            {


                var bookslot = CreateBookingSlot(bookingDTO);


                var create = new StringBuilder();

                if (bookslot == true)
                {
                    create.Append("END ");

                    create.AppendLine("Dear customer you have succesfully booked a parking slot.");

                    return create.ToString();
                }

                if (bookslot == false)
                {
                    create.Append("END ");

                    create.AppendLine("Sorry we are not able to complete this request, please contact +254 797 587635 for further support.");

                    return create.ToString();
                }

                else
                {
                    return InvalidOption();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public static bool CreateBookingSlot(BookingDTO bookingDTO)
        {
            using (ApplicationDBContext context = new ApplicationDBContext())
            {
                var booking = new Customer
                {
                    Id = Guid.NewGuid(),

                    FirstName = bookingDTO.CustomerName,

                    PhoneNumber = bookingDTO.PhoneNumber,
                };

                context.Customers.Add(booking);

                var res = context.SaveChanges();

                if (res > 0)
                {
                    return true;
                }

                return false;
            }
        }
        public static string InvalidOption()
        {
            try
            {
                var cp = new StringBuilder();

                cp.Append("END ");

                cp.AppendLine("You have entered invalid option");

                return cp.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var response = new StringBuilder();

                response.AppendLine("Please contact+254 797 587635 for further support");

                return response.ToString();
            }
        }
    }
}