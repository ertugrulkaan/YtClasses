using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSistemiProject.Abstract
{
    public interface IPersonCheckService
    {
        // User'i al ve dogruluguna gore bool dondur

        bool CheckUserIsReal(PersonConcrete person);
    }
}
