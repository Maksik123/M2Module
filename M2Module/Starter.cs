using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;
using M2Module.Services;
using M2Module.Interfaces;
using M2Module.Extensions;

namespace M2Module
{
    public class Starter
    {
        ManchesterUnitedLineUp manchesterUnitedLineUp = new ManchesterUnitedLineUp();

        private readonly IChooseGroupOfPlayers chooseGroupOfPlayers;
        public FootballTeam footballTeam;

        public void Run()
        {
            Console.WriteLine("Please write position of players you want to see:");
            string usertext = Console.ReadLine();
            footballTeam.Team = manchesterUnitedLineUp.GetFootballPlayers();
            var groupOfPlayers = chooseGroupOfPlayers.GetGroupOfPlayers(usertext);
            ConsoleArrayOutputExtension.ConsoleArrayOutput(groupOfPlayers);
        }
    }
}
