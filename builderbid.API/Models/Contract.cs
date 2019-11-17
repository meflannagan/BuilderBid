using System;
using System.Collections.Generic;

namespace builderbid.API.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double StartingBid { get; set; }
        public double WinningBid { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}