using ABPD07.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD07.Responses
{
    public class TripResponse
    {
        public int IdTrip { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int MaxPeople { get; set; }

        public List<ClientResponse> Clients { get; set; }

        public List<CountryResponse> Countries { get; set; }


    }
}
