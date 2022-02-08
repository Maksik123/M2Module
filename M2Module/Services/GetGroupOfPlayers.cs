using M2Module.ExceptionConfig;
using M2Module.Interfaces;
using M2Module.Models;

namespace M2Module.Services
{
    public class GetGroupOfPlayers : IGetGroupOfPlayers
    {
        private readonly IGenerateLineUp lineUp;

        public GetGroupOfPlayers(IGenerateLineUp lineUp)
        {
            this.lineUp = lineUp;
        }

        public static int Counter = 1;

        public FootballPlayer[] AllPlayers { get; set; }

        public FootballPlayer[] GroupOfPlayers { get; set; } = new FootballPlayer[Counter];

        public FootballPlayer[] GetGroup(string text)
        {
            AllPlayers = lineUp.GetFootballPlayers();
            try
            {
                switch (text)
                {
                    case "Forward":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    var group = new FootballPlayer[Counter];
                                    group = GroupOfPlayers;
                                    Array.Resize(ref group, Counter);
                                    group[Counter - 1] = player;
                                    GroupOfPlayers = new FootballPlayer[Counter];
                                    GroupOfPlayers = group;
                                    Counter++;
                                }
                            }

                            Counter = 1;
                            return GroupOfPlayers;
                        }

                    case "Midfielder":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    var group = new FootballPlayer[Counter];
                                    group = GroupOfPlayers;
                                    Array.Resize(ref group, Counter);
                                    group[Counter - 1] = player;
                                    GroupOfPlayers = new FootballPlayer[Counter];
                                    GroupOfPlayers = group;
                                    Counter++;
                                }
                            }

                            Counter = 1;
                            return GroupOfPlayers;
                        }

                    case "Goalkeeper":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    var group = new FootballPlayer[Counter];
                                    group = GroupOfPlayers;
                                    Array.Resize(ref group, Counter);
                                    group[Counter - 1] = player;
                                    GroupOfPlayers = new FootballPlayer[Counter];
                                    GroupOfPlayers = group;
                                    Counter++;
                                }
                            }

                            Counter = 1;
                            return GroupOfPlayers;
                        }

                    case "Defender":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    var group = new FootballPlayer[Counter];
                                    group = GroupOfPlayers;
                                    Array.Resize(ref group, Counter);
                                    group[Counter - 1] = player;
                                    GroupOfPlayers = new FootballPlayer[Counter];
                                    GroupOfPlayers = group;
                                    Counter++;
                                }
                            }

                            Counter = 1;
                            return GroupOfPlayers;
                        }

                    default:
                        {

                            throw new InvalidInputException(text);
                        }
                }
            }
            catch (InvalidInputException exception)
            {
                Console.WriteLine("Error: Unknown Position");
            }

            return new FootballPlayer[0];
        }
    }
}
