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

        public FootballPlayer[] AllPlayers { get; set; }

        public FootballPlayer[] GroupOfPlayers { get; set; }

        public FootballPlayer[] GetGroup(string text)
        {
            int Counter = 0;
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
                                    GroupOfPlayers[Counter] = player;
                                    Counter++;
                                }
                            }

                            break;
                        }

                    case "Midfielder":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    GroupOfPlayers[Counter] = player;
                                    Counter++;
                                }
                            }

                            break;
                        }

                    case "Goalkeeper":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    GroupOfPlayers[Counter] = player;
                                    Counter++;
                                }
                            }

                            break;
                        }

                    case "Defender":
                        {
                            foreach (var player in AllPlayers)
                            {
                                if (text == player.Position)
                                {
                                    GroupOfPlayers[Counter] = player;
                                    Counter++;
                                }
                            }

                            break;
                        }

                    default:
                        {
                            throw new InvalidInputException(text);
                        }
                }
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Error: Unknown Position");
            }

            return GroupOfPlayers;
        }
    }
}
