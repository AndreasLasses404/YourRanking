using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourRanking.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public List<User> Users { get; set; }
        public Arena Arena { get; set; }
    }
}
