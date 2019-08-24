using System;
using System.Collections.Generic;

namespace ITRW324Project2_MVC_
{
    public partial class BookedCourt
    {
        public int BookedCourtId { get; set; }
        public int? NumberOfBookings { get; set; }
        public string BookedCourtStatus { get; set; }
        public int? BookingId { get; set; }
        public int? CourtId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Court Court { get; set; }
    }
}
