using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourRanking.Models
{
    public class User : IdentityUser
    {
        public bool IsReferee { get; set; }
        public int Rating { get; set; }
        public int Ranking { get; set; }
        public List<Matches> Matches { get; set; }
    }
}
