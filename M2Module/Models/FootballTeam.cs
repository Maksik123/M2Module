using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Module.Models
{
    public abstract class FootballTeam
    {
        public abstract string FootballTeamName { get; }

        public FootballPlayer[] Team { get; set; }

    }
}
