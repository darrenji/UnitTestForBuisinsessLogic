using FourthDemo.Impl.Models;
using FourthDemo.Impl.Repositories.Interfaces;
using FourthDemo.Impl.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepo;

        public LeagueService(ILeagueRepository leagueRepo)
        {
            _leagueRepo = leagueRepo;
        }

        public bool IsValid(int id)
        {
            return _leagueRepo.IsValid(id);
        }

        public List<League> GetAll()
        {
            return _leagueRepo.GetAll();
        }
    }
}
