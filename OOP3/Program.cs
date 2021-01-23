using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager transportationCreditManager = new TransportationCreditManager();
            ICreditManager needsCreditManager = new NeedsCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager esnafCreditManager = new EsnafCreditManager();

            // Basvuru sinifimizdan apply i cagirip tasit kredisine basvurttuk.
            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(esnafCreditManager, new List<ILoggerService> { 
                new DatabaseLoggerService(),new SmsLoggerService() } );
            // Kullanicinin cekecegi kredi hangisinde daha az masrafli olacaksa onu gormesi icin butun kredilerin tipinde bir liste olusturup bunu bilgi alma methoduna gonderdik.
            List<ICreditManager> creditList = new List<ICreditManager>();
            creditList.Add(transportationCreditManager);
            creditList.Add(needsCreditManager);
            creditList.Add(mortgageCreditManager);
            //applyManager.GiveCreditInformation(creditList);

        }
    }
}
