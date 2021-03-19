
using OyunOdevi.Abstract;
using OyunOdevi.Business.Concrete;
using System;
using System.Collections.Generic;

namespace OyunOdevi
{
    class Program
    {

        static void Main(string[] args)
        {
            


            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "YILBAŞI İNDİRİMİ";
            campaign1.DiscountRate = 20;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = "SÖMESTR İNDİRİMİ";
            campaign2.DiscountRate = 45;

            List<Campaign> campaigns = new List<Campaign>() { campaign1, campaign2 };
            
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.List(campaigns);
            campaignManager.Update(campaign2);

            Player player1 = new Player();

            player1.Id = 3;
            player1.FirstName = "Ali";
            player1.LastName = "YILMAZ";
            player1.NationalityId = "12345678";
            player1.DateOfBirth = 1995;
            player1.NickName = "VurucuTim";
           
            
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);



            Game game1 = new Game();
            game1.Id = 4;
            game1.Name = "VALORANT";
            game1.Genre = "FPS";
            game1.Price = 55;

            OrderManager orderManager = new OrderManager();
            orderManager.NormalOrder(player1,game1);
            orderManager.OrderWithCampaign(player1, game1, campaign2);
        
        
        }

    }
}
