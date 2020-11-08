using FourthDemo.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Impl.Services.Interfaces
{
    public interface ITeamService
    {
        List<Team> Search(TeamSearch search);
    }
}
