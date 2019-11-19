using System.Collections.Generic;

namespace builderbid.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        
    }
}