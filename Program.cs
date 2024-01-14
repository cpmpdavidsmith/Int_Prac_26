using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining the Sorted list
            SortedList ar = new SortedList();

            //Adding elements to the Sorted List
            ar.Add(111, "Chicken");
            ar.Add(222, "Master");
            ar.Add(333, "Egg");

            Console.WriteLine("The first value of the Sortedlist is " + ar[111].ToString());
            Console.WriteLine("The second value of the SortedList is " + ar[222].ToString());
            Console.WriteLine("The third value of the SortedList is " + ar[333].ToString());
            Console.Read();
        }
    }
}