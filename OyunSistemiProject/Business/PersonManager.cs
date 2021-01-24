using OyunSistemiProject.Abstract;
using OyunSistemiProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Business
{
    class PersonManager : IManager
    {
        private PersonConcrete _person;

        public PersonManager(PersonConcrete person, IPersonCheckService personCheckService)
        {
            if (personCheckService.CheckUserIsReal(person))
            {
                _person = person;
            }
            else
            {
                throw new Exception("Kullanici gercek bir kisi degildir.");
            }
        }
        public void Add()
        {
            Console.WriteLine(_person.FirstName + " Added to Db");
        }

        public void Delete()
        {
            /*
             _person ile silme islemleri vsvs
             */ 
            Console.WriteLine(_person.FirstName + " Deleted from db");
        }

        public void Select()
        {
            Console.WriteLine("User Information");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("User Id: " + _person.Id);
            Console.WriteLine("User FirstName : " + _person.FirstName);
            Console.WriteLine("User LastName : " + _person.LastName);
            Console.WriteLine("User IdentityNumber : " + _person.IdentityNumber);
            Console.WriteLine("User DateofBirth : " + _person.DateofBirth);
            Console.WriteLine("-----------------------------------------------");
        }

        public void Update()
        {
            Console.WriteLine("User Id = " + _person.Id + "  is updated in db");
        }
    }
}
