using FourthDemo.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetByID(int id);
        List<Player> GetForTeam(int id);
    }
}
