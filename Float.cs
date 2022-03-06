using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFloatMx
{
    public class Float<T> where T : IComparable

    {
        public T firstvalue, secondvalue, thirdvalue;


        public Float(T firstvalue,  T secondvalue, T thirdvalue)
        {

            this.firstvalue = firstvalue;

            this.secondvalue = secondvalue;

            this.thirdvalue = thirdvalue;




        }

        public  void Max(double firstvalue, double secoundvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secoundvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            //firstValue.CompareTo(secoundValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
            //firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(firstvalue);
            }
            if (secoundvalue.CompareTo(firstvalue) > 0 && secoundvalue.CompareTo(thirdvalue) > 0)
            //secoundValue.CompareTo(firstValue) >= 0 && secoundValue.CompareTo(thirdValue) > 0 ||
            //secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(secoundvalue);
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(firstvalue) > 0)
            //thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
            //thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine(thirdvalue);
            }
            


        }

    }
}
