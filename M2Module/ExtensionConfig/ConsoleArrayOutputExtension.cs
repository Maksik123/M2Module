using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;

namespace M2Module.ExtensionConfig
{
    public static class ConsoleArrayOutputExtension
    {
        public static void ConsoleArrayOutput(FootballPlayer[] footballPlayers)
        {
            foreach (var player in footballPlayers)
            {
                Console.WriteLine($"{player.Name}, {player.Position}, {player.Age} Ages, Rating: {player.Rating}");
            }
        }
    }
}
