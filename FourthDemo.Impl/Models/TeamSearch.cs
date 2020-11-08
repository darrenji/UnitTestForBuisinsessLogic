using FourthDemo.Impl.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Models
{
    public class TeamSearch
    {
        public int LeagueID { get; set; }
        public DateTime FoundingDate { get; set; }
        public SearchDateDirection Direction { get; set; }
        public List<Team> Results { get; set; }
       
    }
}
