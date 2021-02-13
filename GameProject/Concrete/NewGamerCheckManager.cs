using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class NewGamerCheckManager : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            return true;
        }
    }
}
