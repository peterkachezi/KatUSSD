using System;

namespace WebApplication1.DTOs
{
    public class BookingDTO
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } 
        public string PhoneNumber { get; set; }
        public string TransactionNumber { get; set; }
        public bool IsBooked { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ParkingSlotId { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ReceiptNumber { get; set; }
        public string SlotName { get; set; }
        public string CarRegNo { get; set; }

    }
}