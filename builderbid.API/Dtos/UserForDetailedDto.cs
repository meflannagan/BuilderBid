using System.Collections.Generic;
using builderbid.API.Models;

namespace builderbid.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
        public ICollection<Bid> Bids { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}