using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Abstract
{
    public abstract class CampaignConcrete
    {
        // Genel Campaign tanimlamasi
        public int Id { get; set; }
        public string Name { get; set; }
        // %20 ise 20 girilmeli
        public double DiscountRate { get; set; }
    }
}
