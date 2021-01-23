using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandi.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
