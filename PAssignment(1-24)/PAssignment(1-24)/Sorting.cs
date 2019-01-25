using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAssignment_1_24_
{
    class Sorting
    {
        public int[] sorted(int [] array)
        {
            // initalize variables
            int[] newarray = new int[array.Length];
            int temp = 0;

            // bubble sort to save smallest values to front
            for(int write = 0; write < array.Length; write++){
                for (int sort = 0; sort < array.Length - 1; sort++){
                    if (array[sort] > array[sort + 1]){
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            // make initalized array copy of sorted array
            for(int i = 0; i < array.Length; i++){
                newarray[i] = array[i];
            }
           
            // send out copied sorted array
            return newarray;
        }
    }
}
