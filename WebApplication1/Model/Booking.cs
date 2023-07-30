using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1
{
    public partial class Booking
    {
        public Guid Id { get; set; }

        public byte Status { get; set; }

        public Guid CustomerId { get; set; }

        public Guid ParkingSlotId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedBy { get; set; }

        [Required]
        public string ReceiptNumber { get; set; }

        [Required]
        public string CarRegNo { get; set; }

        public virtual ParkingSlot ParkingSlot { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
