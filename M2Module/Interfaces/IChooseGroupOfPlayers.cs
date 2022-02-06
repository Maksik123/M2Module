﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2Module.Models;

namespace M2Module.Interfaces
{
    public interface IChooseGroupOfPlayers
    {
        public FootballPlayer[] GetGroupOfPlayers(string text);
    }
}
