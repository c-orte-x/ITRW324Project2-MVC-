using System;
using System.Collections.Generic;

namespace Final
{
    public partial class User
    {
        public User()
        {
            Booking = new HashSet<Booking>();
            HostedAt = new HashSet<HostedAt>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhoneNum { get; set; }
        public string UserGender { get; set; }
        public DateTime UserMemberSince { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<HostedAt> HostedAt { get; set; }
    }
}
