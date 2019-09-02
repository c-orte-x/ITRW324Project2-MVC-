using System;
using System.Collections.Generic;

namespace Final
{
    public partial class Booking
    {
        public Booking()
        {
            BookedCourt = new HashSet<BookedCourt>();
            OccupiedCourt = new HashSet<OccupiedCourt>();
        }

        public int BookingId { get; set; }
        public DateTime? BookingFrom { get; set; }
        public DateTime? BookingUntil { get; set; }
        public string BookingMadeBy { get; set; }
        public int? UserId { get; set; }
        public int? CourtNr { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<BookedCourt> BookedCourt { get; set; }
        public virtual ICollection<OccupiedCourt> OccupiedCourt { get; set; }
    }
}
