using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Vote_Info
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Firstvote { get; set; }
        public int Secondvote { get; set; }
        public int Thirdvote { get; set; }
        public int Forthvote { get; set; }
        public int Fifthvote { get; set; }
        public int Sixthvote { get; set; }
        public string Seventhvote { get; set; }
        public string Eighthvote { get; set; }
        public System.DateTime Votetime { get; set; }
    }
}
