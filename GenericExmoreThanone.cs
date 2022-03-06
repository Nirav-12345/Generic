using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExtendParameter
{
    public class GenericExmoreThanone<T> where T : IComparable
    {
        public T[] value;

        public GenericExmoreThanone(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);

            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        public T Maxmethod()
        {
            var max = MaxValue(this.value);

            return max;
        }

        public void MaxvlauePrint()
        {
            var max = MaxValue(this.value);

            Console.WriteLine("The maximum vlaue is" + max);
        }

        public static void Main(string[] args)
        {

            int[] ar = { 112, 344, 555, 666, 788 };

            GenericExmoreThanone<int> generic = new GenericExmoreThanone<int>(ar);
            generic.MaxvlauePrint();
            

        }
        



    }
    
}
