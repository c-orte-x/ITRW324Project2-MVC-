using System;
using System.Collections.Generic;

namespace Final
{
    public partial class Court
    {
        public Court()
        {
            BookedCourt = new HashSet<BookedCourt>();
            OccupiedCourt = new HashSet<OccupiedCourt>();
        }

        public int CourtId { get; set; }
        public string CourtNum { get; set; }
        public string CourtStatus { get; set; }

        public virtual ICollection<BookedCourt> BookedCourt { get; set; }
        public virtual ICollection<OccupiedCourt> OccupiedCourt { get; set; }
    }
}
