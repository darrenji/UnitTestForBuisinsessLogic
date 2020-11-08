using FourthDemo.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetByID(int id);

        List<Player> GetForLeague(int leagueID);
    }
}
