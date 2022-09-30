using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl.console
{
    public class DalFactory
    {
        public static IDal GetDal()
        {
            return new Dal();
        }
    }
}
