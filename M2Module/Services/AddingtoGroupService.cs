using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M2Module.Models;

namespace M2Module.Services
{
    public class AddingToGroupService
    {
        public FootballPlayer[] addingToGroup(string text, FootballPlayer[] AllPlayers)
        {
            var Counter = 1;
            var GroupOfPlayers = new FootballPlayer[Counter];

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

            return GroupOfPlayers;
        }
    }
}
