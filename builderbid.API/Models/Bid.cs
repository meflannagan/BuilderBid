using System;

namespace builderbid.API.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public double Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsWinner { get; set; }
    }
}