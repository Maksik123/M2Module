﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Interfaces;
using M2Module.Models;
using M2Module.ExceptionConfig;

namespace M2Module.Services
{
    public class ChooseGroupOfPlayers : IChooseGroupOfPlayers
    {
        private readonly IGenerateLineUp lineUp;

        private readonly FootballPlayer footballPlayer;

        public FootballPlayer[] AllPlayers { get; set; }

        public FootballPlayer[] GroupOfPlayers { get; set; }

        private int counter;

        public FootballPlayer[] GetGroupOfPlayers(string text)
        {
            AllPlayers = lineUp.GetFootballPlayers();

            foreach (var player in AllPlayers)
            {
                try
                {
                    if (text == footballPlayer.Position)
                    {
                        if (text == "Forward")
                        {
                            GroupOfPlayers[counter] = player;
                            counter++;
                        }

                        if (text == "Goalkeeper")
                        {
                            GroupOfPlayers[counter] = player;
                            counter++;
                        }

                        if (text == "Midfielder")
                        {
                            GroupOfPlayers[counter] = player;
                            counter++;
                        }

                        if (text == "Defender")
                        {
                            GroupOfPlayers[counter] = player;
                            counter++;
                        }
                    }
                    else
                    {
                        throw new InvalidInputException(text);
                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine($"error: {ex.Message}");
                }
            }

            return GroupOfPlayers;
        }
    }
}
