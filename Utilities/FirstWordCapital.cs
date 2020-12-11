using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.Utilities
{
    public static class FirstWordCapital
    {
        public static string FirstWordCapitalize(this string input)
        {
            if (input.Length > 0)
            {
                char[] chararray = input.ToCharArray();
                chararray[0] = char.IsUpper(chararray[0]) ? chararray[0] : char.ToUpper(chararray[0]);
                return new string(chararray);

            }
            return input;
        }
    }
}
