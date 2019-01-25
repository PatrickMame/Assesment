using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAssignment_1_24_
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize all variables
            string draw = "";
            Sorting NewSort = new Sorting();
            int[] array = { 0, 1, 1, 0, 1, 0, 1, 0, 0, 1 };

            // print out the array in it's sorted form
            for(int num = 0; num < array.Length; num++){
                draw += NewSort.sorted(array)[num];
            }

            // print it and end it
            Console.WriteLine(draw);
            Console.ReadLine();
        }
    }
}
