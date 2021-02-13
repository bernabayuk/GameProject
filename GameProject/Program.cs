using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new GamerCheckService());
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Berna", LastName = "Bayuk", DateOfBirth = new DateTime(1995, 5, 17), NationalityId = "12345678910" };

            Game game1 = new Game() { Id = 1, Name = "PUBG", Price = 600 };
            Game game2 = new Game() { Id = 2, Name = "GTA 5", Price = 500 };

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Yeni Üye Kampanyası", DiscountRate = 10 };

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer1);
            salesManager.CampaignSales(game2, gamer1, campaign1);
        }
    }
}
