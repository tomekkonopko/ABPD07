using System;
using System.Collections.Generic;

#nullable disable

namespace ABPD07.Models
{
    public partial class ClientTrip
    {
        public int IdClient { get; set; }
        public int IdTrip { get; set; }
        public int RegisteredAt { get; set; }
        public int? PaymentDate { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Trip IdTripNavigation { get; set; }

        public static implicit operator ClientTrip(ClientTrip v)
        {
            throw new NotImplementedException();
        }
    }
}
