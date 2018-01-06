using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetApp
{
    class BetDetails
    {
        public string HorseName { get; set; }
        public string RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Flag { get; set; }
    }
}
