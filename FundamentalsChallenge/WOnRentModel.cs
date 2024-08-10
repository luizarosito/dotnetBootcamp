using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.FundamentalsChallenge
{
    public class WOnRentModel
    {
        public List<string>? transport { get; set; }
        public decimal initialPrice { get; set; }
        public decimal hourlyRate { get; set; }
        public string wheelCode { get; set; }
        public int totalTime { get; set; }
        public decimal totalPrice  { get; set; }

    }
}