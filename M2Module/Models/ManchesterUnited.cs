using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;

namespace M2Module.Models
{
    public class ManchesterUnited : FootballTeam
    {
        private readonly ManchesterUnitedLineUp manchesterUnitedLineUp;

        public override string FootballTeamName => "Manchester United";

        public FootballPlayer[] Team { get; set; } = new FootballPlayer[1];

        public ManchesterUnited()
        {

        }

        private void BuildTeam(FootballPlayer[] footballPlayers)
        {
            Team = manchesterUnitedLineUp.GetFootballPlayers();
        }

    }
}
