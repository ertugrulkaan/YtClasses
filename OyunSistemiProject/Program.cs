using OyunSistemiProject.Abstract;
using OyunSistemiProject.Business;
using OyunSistemiProject.Entity;
using System;

namespace OyunSistemiProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //classlardan instancelar olusturuluyor.
            PersonConcrete person = new Person() {Id=1,FirstName="Ertugrul",LastName="Ozdemir",IdentityNumber="11111111111",DateofBirth=DateTime.Now};
            GameConcrete game = new Game() { Id = 1, Name = "Pubg", CategoryName = "Aksiyon", Price = 50.0 };
            CampaignConcrete campaign = new Campaing() { Id=1,Name="Koronanin allah belasini versin indirimleri",DiscountRate=50 };
            //Yeni bir kullanici eklendi.
            IManager manager = new PersonManager(person, new PersonCheckManager());
            manager.Add();
            manager.Delete();
            manager.Update();
            manager.Select();
            //Yeni bir kampanya eklendi.
            IManager manager1 = new CampaignManager(campaign);
            manager1.Add();
            manager1.Delete();
            manager1.Update();
            manager1.Select();
            //Kullanici Indirimsiz satin alma yapiyor.
            ISalesManager salesManager = new SalesManager(person,game);
            salesManager.Buy();

            //Kullanici Indirimli satin alma yapiyor.

            ISalesManager salesManager2 = new SalesManager(person, game,campaign);
            salesManager2.Buy();



        }
    }
}
