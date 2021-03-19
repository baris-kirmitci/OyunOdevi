using OyunOdevi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private IEnumerable<object> campaigns;

        public void Add(Campaign campaing)
        {
            Console.WriteLine("Campaign was added = " + campaing.Name);
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine("Campaign was deleted = " + campaing.Name);
        }

        public void List(List<Campaign> campaigns)
        {
            Console.WriteLine("Campaigns was listed.");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.Name);
            }

        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine("Campaign was updated = " + campaing.Name);
        }
    }
}
