using System;

namespace GenericFindMax;

class Program
{
    public static void Main(String[] args)
    {
        FindMax<int> q = new FindMax<int>(2,3,4);

        q.ToPrint(22, 23, 4);

        


    }
}