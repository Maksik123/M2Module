using M2Module.ExtensionConfig;
using M2Module.Interfaces;
using M2Module.Models;

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
            while ( usertext != "Exit")
            {
                var group = getGroupOfPlayers.GetGroup(usertext);
                if (group is not null)
                {
                    ConsoleArrayOutputExtension.ConsoleArrayOutput(group);
                }
                usertext = Console.ReadLine();
            }
        }
    }
}
