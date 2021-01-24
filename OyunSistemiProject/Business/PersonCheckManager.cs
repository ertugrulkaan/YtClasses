using OyunSistemiProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Business
{
    class PersonCheckManager : IPersonCheckService
    {
        bool _personIsReal=false;
        public bool CheckUserIsReal(PersonConcrete person)
        {
            //TODO : Mernise gore manager olusturup check etmek gerekir
            if (true)
            {
                Console.WriteLine("Kullanici gercek bir kisidir.");
                _personIsReal = true;
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz.");
            }
            return _personIsReal;
        }
    }
}
