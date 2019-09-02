using System;
using System.Collections.Generic;

namespace Final
{
    public partial class OccupiedCourt
    {
        public OccupiedCourt()
        {
            HostedAt = new HashSet<HostedAt>();
        }

        public int OccupiedCourtId { get; set; }
        public DateTimeOffset? CheckIn { get; set; }
        public DateTimeOffset? CheckOut { get; set; }
        public int? CourtId { get; set; }
        public int? BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Court Court { get; set; }
        public virtual ICollection<HostedAt> HostedAt { get; set; }
    }
}
