using FourthDemo.Impl.Models;
using FourthDemo.Impl.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        public League GetByID(int leagueID)
        {
            throw new NotImplementedException();
        }

        public List<League> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}
