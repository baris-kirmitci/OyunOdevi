using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi.Abstract
{
   interface ICampaignService
    {
        public void Add(Campaign campaing);
        public void Delete(Campaign campaing);
        public void Update(Campaign campaing);
        public void List(List<Campaign> campaigns);
    }
}
