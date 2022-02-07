using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;
using M2Module.Services;
using M2Module.Interfaces;
using M2Module.ExtensionConfig;

namespace M2Module
{
    public class Starter
    {
        private readonly IGenerateLineUp generateLineUp;
        private readonly IGetGroupOfPlayers getGroupOfPlayers;

        private readonly FootballTeam footballTeam;

        public Starter(IGenerateLineUp generateLineUp, IGetGroupOfPlayers chooseGroupOfPlayers, FootballTeam footballTeam)
        {
            this.generateLineUp = generateLineUp;
            this.getGroupOfPlayers = chooseGroupOfPlayers;
            this.footballTeam = footballTeam;
        }

        public void Run()
        {
            Console.WriteLine($"{footballTeam.FootballTeamName} Line-Up:");
            footballTeam.TeamLineUp = generateLineUp.GetFootballPlayers();
            var lineUp = footballTeam.TeamLineUp;
            ConsoleArrayOutputExtension.ConsoleArrayOutput(lineUp);
            Console.WriteLine("Please write position of players you want to see:");
            string usertext = Console.ReadLine();
            var group = getGroupOfPlayers.GetGroup(usertext);
            ConsoleArrayOutputExtension.ConsoleArrayOutput(group);

        }
    }
}
