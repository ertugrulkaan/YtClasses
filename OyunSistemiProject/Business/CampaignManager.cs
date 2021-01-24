using OyunSistemiProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Business
{
    class CampaignManager : IManager
    {
        private CampaignConcrete _campaign;
        public CampaignManager(CampaignConcrete campaign)
        {
            _campaign = campaign;
        }

        public void Add()
        {
            Console.WriteLine(_campaign.Name + " isimli kampanya sisteme eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine(_campaign.Name + " isimli kampanya sistemden silindi.");
        }

        public void Select()
        {
            Console.WriteLine("Campaign Information");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Campaign Id: " + _campaign.Id);
            Console.WriteLine("Campaign Name : " + _campaign.Name);
            Console.WriteLine("Campaign Discount Rate : %" + _campaign.DiscountRate);
            Console.WriteLine("-----------------------------------------------");
        }

        public void Update()
        {
            Console.WriteLine(_campaign.Name + " isimli kampanya sistemde guncellendi.");
        }
    }
}
