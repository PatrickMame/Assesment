using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAssignment._2_1_24_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool Palindrome(string testword){
            int counter = 0;
            // checks code to see if
            for(int word = 0; word < testword.Length; word++){
                for(int sort = testword.Length; sort >= 0; sort--){
                    if(testword[word] == testword[sort]){
                        counter++;
                    }
                }
            }
            
            if (counter == testword.Length){
                return true;
            }else{
                return false;
            }
        }
    }
}
