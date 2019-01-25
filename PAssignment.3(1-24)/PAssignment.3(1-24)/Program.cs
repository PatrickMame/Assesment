using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PAssignment._3_1_24_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current Problem: missing top layer and bottom layer
            // initialize variables
            List<string> teststring = new List<string>();
            string filelocation = "C:\\Users\\CCA023\\Desktop\\WritingFile.txt";
            string userinput = ",";
            int counter = 0;

            // an attempt to try to create a loop to save user input \
            while (userinput != ""){
                counter++;
                userinput = Console.ReadLine();
                teststring.Add(userinput);
            }

            string[] file = new string[counter];
            file = teststring.ToArray();

            // call the function
            PrintToLength(file, filelocation);
            Console.ReadKey();

        }

        static string Prompt(string Ui)
        {
            Console.Write(Ui + "");
            return Console.ReadLine();
        }

        // 
        static void PrintToLength(string[] array, string filelocation)
        {
            string temp;
            int newlength;
            StreamWriter location = new StreamWriter(filelocation);

            // an attempted bubble sort to get the value with the longest length
            for (int write = 0; write < array.Length; write++){
                for (int sort = 0; sort < array.Length - 1; sort++) {
                    if (array[sort].Length > array[write].Length){
                        temp = array[write];
                        array[write] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            // save the first(and presumed longest) value's length to always be bigger
            newlength = array[0].Length + 2;

            // write the top line based on the newlength
            for(int i = 0; i < newlength;i++){
                location.Write("*");
            }

            location.Write("/n");
            // write the body of the text using fucntion that may work better with list
            foreach (string word in array){
                location.WriteLine("" + NewLine(word, newlength));
            }

            location.Write("/n");
            // write bottom line
            for (int i = 0; i < newlength; i++)
            {
                location.Write("*");
            }
            // close the file
            location.Close();
        }

        static string NewLine(string input, int number)
        {
            string output;
            
            output = "* " + input;
            while(output.Length < number ){
                output += " ";
            }
            output += "*";

            return output;
        }
    }
}
