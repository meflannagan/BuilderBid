using System;
using System.Collections.Generic;
using builderbid.API.Models;

namespace builderbid.API.Dtos
{
    public class ContractForDetailedDto
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
        public ICollection<Photo> Photos { get; set; }
    }
}