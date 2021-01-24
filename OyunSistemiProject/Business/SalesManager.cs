using OyunSistemiProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Business
{
    class SalesManager : ISalesManager
    {
        private PersonConcrete _person;
        private GameConcrete _game;

        double Price = 0.0;

        //Indirim olmadan kullanilirsa
        public SalesManager(PersonConcrete person,GameConcrete game)
        {
            _person = person;
            _game = game;
            Price = game.Price;

        }
        //Indirimli kullanilirsa

        public SalesManager(PersonConcrete person, GameConcrete game, CampaignConcrete campaign)
        {
            _person = person;
            _game = game;
            Price = DiscountedPrice(game, campaign);
        }

        // Methods
        public void Buy()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("SATIN ALIM GERCEKLESTI");
            Console.WriteLine(_person.FirstName + " isimli kullanici " + _game.Name + " isimli oyunu # "+ Price + " #  TL karsiliginda satin aldi.");
            Console.WriteLine("================================================");
        }

        public double DiscountedPrice(GameConcrete game, CampaignConcrete campaign)
        {
            // 50 * 1 - 0.2 = 40
            return game.Price  * (1 - campaign.DiscountRate / 100);
        }
    }
}
