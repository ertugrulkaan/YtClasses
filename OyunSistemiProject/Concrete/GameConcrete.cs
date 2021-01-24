using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Abstract
{
    public abstract class GameConcrete
    {
        // Genel Game tanimlamasi
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }

    }
}
