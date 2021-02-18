using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Firebase_Test.Models
{
    public class Robot
    {
        public string RobotId { get; set; }
        public string Name { get; set; }
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public int TieCount { get; set; }
        public string EnteredBy { get; set; }
        public DateTime EnteredDate { get; set; }
    }
}
