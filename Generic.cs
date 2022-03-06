using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactGener3_Vars
{
    public class Generic<T> where T:IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;


        public Generic(T firstvalue, T secondvalue, T thirdvalue)
        {

            this.firstvalue = firstvalue;

            this.secondvalue = secondvalue;

            this.thirdvalue = thirdvalue;
        }


         public static T Max(T firstvalue, T secondvalue, T thirdvalue)
            {
                if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 || firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(secondvalue) > 0 || firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
                {
                    return firstvalue;
                }



                if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
                {
                    return secondvalue;
                }

                if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(secondvalue) > 0 && thirdvalue.CompareTo(firstvalue) >= 0)
                {
                    return thirdvalue;
                }

                return default;
            }


             public T MaxMethod()
            {
                T max = Generic<T>.Max(this.firstvalue, this.secondvalue, this.thirdvalue);

                return max;
            }






            









    }
}
