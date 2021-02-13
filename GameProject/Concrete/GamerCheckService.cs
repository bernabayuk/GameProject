using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerCheckService : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            if(gamer.Id == 1 && gamer.FirstName == "Berna" && gamer.LastName == "Bayuk" && gamer.DateOfBirth.Year == 1995 && gamer.NationalityId == "12345678910")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
