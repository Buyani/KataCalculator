using System;
using System.Collections.Generic;
using System.Text;

namespace KataCalculator
{
    public class StringKataCalculator
    {
        public object Add(string stringnumber)
        {
            if (String.IsNullOrEmpty(stringnumber) || stringnumber.Equals(" "))
                return 0;
            return 1;
        }
    }
}
