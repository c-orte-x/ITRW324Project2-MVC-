using System;
using System.Collections.Generic;

namespace Final
{
    public partial class HostedAt
    {
        public int HostId { get; set; }
        public int UserId { get; set; }
        public int OccupiedCourtId { get; set; }

        public virtual OccupiedCourt OccupiedCourt { get; set; }
        public virtual User User { get; set; }
    }
}
