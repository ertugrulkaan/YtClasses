using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Abstract
{
    interface ISalesManager
    {
        //Temel satin alma methodu
        void Buy();
        //Indirim methodu
        double DiscountedPrice(GameConcrete game, CampaignConcrete campaign);
    }
}
