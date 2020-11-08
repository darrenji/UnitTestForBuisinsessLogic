using FourthDemo.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories.Interfaces
{
    public interface ILeagueRepository
    {
        League GetByID(int id);
        List<League> GetAll();
        bool IsValid(int leagueID);
    }
}
