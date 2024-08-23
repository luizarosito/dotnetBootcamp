using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.HostingProjectChallenge.Models
{
    public class Home
    {
        public Home(string type, int capacity, decimal monthlyValue)
        {
            Type = type;
            Capacity = capacity;
            MonthlyValue = monthlyValue;
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public decimal MonthlyValue { get; set; }
    }
}