using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Abstract
{
    public abstract class PersonConcrete
    {
        // Genel person tanimlamasi
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DateofBirth { get; set; }

    }
}
