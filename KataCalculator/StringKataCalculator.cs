using System;
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

            //if(stringnumber.StartsWith("//"))
            //{
            //    var numbers = stringnumber.Split('\n').Last().Split(';');
            //    results = numbers.Select(p => int.Parse(p)).Sum();
            //}
            var negatives = stringnumber.Split(',','\n').Select(p => int.Parse(p)).Where(n => n < 0);
            if(negatives.Any())
            {
                string negativeNumbers = String.Join(',', negatives.Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed:{negativeNumbers}");
            }
            results = stringnumber.Split(',','\n').Select(p => int.Parse(p)).Where(p=> p<1000).Sum();
            return results;
        }
    }
}
