﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataCalculator
{
    public class StringKataCalculator
    {
        public object Add(string stringnumber)
        {
            var results = 0;
            if (String.IsNullOrEmpty(stringnumber) || stringnumber.Equals(" "))
                return results;

            if(stringnumber.StartsWith("//"))
            {

            }


            results = stringnumber.Split(',','\n').Select(p => int.Parse(p)).Sum();
            return results;
        }
    }
}
