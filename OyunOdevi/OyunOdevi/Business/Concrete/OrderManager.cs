using OyunOdevi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi.Business.Concrete
{
    class OrderManager : IOrderService
    {
        public void NormalOrder(Player player, Game game)
        {
            Console.WriteLine("Satın alma basarili : " + game.Name + "Ürün Tutarı : " + game.Price + "Keyifli Oyunlar Dileriz : " + player.FirstName);
        }

        public void OrderWithCampaign(Player player, Game game, Campaign campaign)
        {
            double orderPrice = game.Price - (game.Price * (campaign.DiscountRate / 100));
            Console.WriteLine("Tebrikler " + campaign.Name + "Kampanyasından Yararlandınız." + "Ürün Tutarı : " + orderPrice + " TL " + "Keyifli Oyunlar Dileriz : " + player.FirstName);
        }
    }
}

