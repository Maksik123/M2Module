using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Interfaces;

namespace M2Module.Models
{
    public class ManchesterUnited : FootballTeam, IGenerateLineUp
    {
        private readonly IGenerateLineUp generateLineUp;

        public ManchesterUnited(IGenerateLineUp generateLineUp)
        {
            this.generateLineUp = generateLineUp;
        }

        public override string FootballTeamName => "Manchester United";

        public override FootballPlayer[] TeamLineUp { get ; set ; }

        public FootballPlayer[] GetFootballPlayers()
        {
            TeamLineUp = this.generateLineUp.GetFootballPlayers();
            return TeamLineUp;
        }
    }
}
