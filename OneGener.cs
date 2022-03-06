using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStrFloMax
{
    public class OneGener
    {
        





        public  void Max(int firstvalue,int secondvalue, int thirdvalue, string firststring, string secoundstring, string thirdstring)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 || firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(secondvalue) > 0 || firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine(firstvalue);
            }



            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine(secondvalue);
            }

            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(secondvalue) > 0 && thirdvalue.CompareTo(firstvalue) >= 0)
            {
                Console.WriteLine(thirdvalue);
            }

             

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            //firstValue.CompareTo(secoundValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
            //firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(firstvalue);
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            //secoundValue.CompareTo(firstValue) >= 0 && secoundValue.CompareTo(thirdValue) > 0 ||
            //secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(secondvalue);
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(firstvalue) > 0)
            //thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
            //thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine(thirdvalue);
            }


             
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
