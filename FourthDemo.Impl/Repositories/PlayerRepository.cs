using FourthDemo.Impl.Models;
using FourthDemo.Impl.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Player GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetForTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}
