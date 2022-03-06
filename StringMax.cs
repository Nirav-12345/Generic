using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericString
{
    public class StringMax
    {
        public void StrMax(string firststring, string secoundstring, string thirdstring)
        {
            if (firststring.CompareTo(secoundstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            //firstValue.CompareTo(secoundValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
            //firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(firststring);
            }
            if (secoundstring.CompareTo(firststring) > 0 && secoundstring.CompareTo(thirdstring) > 0)
            //secoundValue.CompareTo(firstValue) >= 0 && secoundValue.CompareTo(thirdValue) > 0 ||
            //secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(secoundstring);
            }
            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(firststring) > 0)
            //thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
            //thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine(thirdstring);
            }

           

        }





    }
}
