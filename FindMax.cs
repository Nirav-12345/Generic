using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMax<T> where T : IComparable

    {
        public T firstvalue, secondvalue, thirdvalue;


        public FindMax(T firstvalue, T secondvalue, T thirdvalue)
        {

            this.firstvalue = firstvalue;

            this.secondvalue = secondvalue;

            this.thirdvalue = thirdvalue;




        }

        



        public  void  ToPrint(int firstvalue , int secondvalue , int thirdvalue )
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


            
        }



    }






}

















