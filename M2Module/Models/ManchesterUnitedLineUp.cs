using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;
using M2Module.Services;
using M2Module.Interfaces;

namespace M2Module.Models
{
    public class ManchesterUnitedLineUp : IGenerateLineUp
    {
        public FootballPlayer[] ManchesterUnitedTeam { get; set; }

        private readonly IGenerateLineUp lineUp;

        public FootballPlayer[] GetFootballPlayers()
        {
            ManchesterUnitedTeam = lineUp.GetFootballPlayers();
            return ManchesterUnitedTeam;
        }
    }
}