using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Interfaces;
using M2Module.Models;

namespace M2Module.Services
{
    public class GenerateManchesterUnitedLineUp : IGenerateLineUp
    {
        public FootballPlayer[] GetFootballPlayers()
        {
            FootballPlayer[] team = new[]
                {
                    new FootballPlayer() { Name = "De Hea", Age = 31, Rating = 85, Position = "Goalkeeper" },
                    new FootballPlayer() { Name = "Ronaldo", Age = 37, Rating = 89, Position = "Forward" },
                    new FootballPlayer() { Name = "Greenwoood", Age = 19, Rating = 79, Position = "Forward" },
                    new FootballPlayer() { Name = "Pogba", Age = 29, Rating = 86, Position = "Midfielder" },
                    new FootballPlayer() { Name = "McTominay", Age = 25, Rating = 84, Position = "Midfielder" },
                    new FootballPlayer() { Name = "Mata", Age = 33, Rating = 76, Position = "Midfielder" },
                    new FootballPlayer() { Name = "Fred", Age = 28, Rating = 82, Position = "Midfielder" },
                    new FootballPlayer() { Name = "Fernandes", Age = 26, Rating = 88, Position = "Midfielder" },
                    new FootballPlayer() { Name = "Sancho", Age = 21, Rating = 85, Position = "Forward" },
                    new FootballPlayer() { Name = "Shaw", Age = 26, Rating = 81, Position = "Defender" },
                    new FootballPlayer() { Name = "Maguire", Age = 28, Rating = 82, Position = "Defender" },
                    new FootballPlayer() { Name = "Telles", Age = 29, Rating = 83, Position = "Defender" },
                    new FootballPlayer() { Name = "Henderson", Age = 24, Rating = 78, Position = "Goalkeeper" },
                };
            return team;
        }
    }
}
