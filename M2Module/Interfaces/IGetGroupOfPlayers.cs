using M2Module.Models;

namespace M2Module.Interfaces
{
    public interface IGetGroupOfPlayers
    {
        public FootballPlayer[] GetGroup(string text);
    }
}
