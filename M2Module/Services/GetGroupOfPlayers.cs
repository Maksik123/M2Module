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

        public AddingToGroupService addtogroup = new AddingToGroupService();

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
                            GroupOfPlayers = addtogroup.addingToGroup(text, AllPlayers);
                            return GroupOfPlayers;
                        }

                    case "Midfielder":
                        {
                            GroupOfPlayers = addtogroup.addingToGroup(text, AllPlayers);
                            return GroupOfPlayers;
                        }

                    case "Goalkeeper":
                        {
                            GroupOfPlayers = addtogroup.addingToGroup(text, AllPlayers);
                            return GroupOfPlayers;
                        }

                    case "Defender":
                        {
                            GroupOfPlayers = addtogroup.addingToGroup(text, AllPlayers);
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
