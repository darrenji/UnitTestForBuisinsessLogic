using FourthDemo.Impl.Models;
using FourthDemo.Impl.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthDemo.Tests.Mocks.Services
{
    public class MockTeamService : Mock<ITeamService>
    {
        public MockTeamService MockSearch(List<Team> results)
        {
            Setup(x => x.Search(It.IsAny<TeamSearch>()))
                .Returns(results);

            return this;
        }

        public MockTeamService VerifySearch(Times times)
        {
            Verify(x => x.Search(It.IsAny<TeamSearch>()), times);

            return this;
        }
    }
}
