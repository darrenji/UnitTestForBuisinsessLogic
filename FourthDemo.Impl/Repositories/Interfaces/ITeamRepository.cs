using FourthDemo.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Team GetByID(int id);
        List<Team> GetForLeague(int leagueID);
    }
}
