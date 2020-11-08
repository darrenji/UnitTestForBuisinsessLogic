using FourthDemo.Impl.Models;
using FourthDemo.Impl.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public Team GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetForLeague(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}
