﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckPerson(Gamer gamer);
    }
}
