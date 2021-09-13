using System;
using System.Linq;

namespace KataCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "//;\n1;3";
            if(number.StartsWith("//"))
            {
                var results = number.Split('\n').Last();

                Console.WriteLine(results.Split(';').Select(p => int.Parse(p)).Sum());
            }
          
            Console.ReadKey();
        }
    }
}
