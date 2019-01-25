using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PAssignment._1_1_24_
{
    class Program
    {
        static void Main(string[] args)
        {
            string comment;
            StreamReader File = new StreamReader("C:\\Users\\CCA023\\source\\repos\\PAssignment(1-24)\\PAssignment(1-24)\\Program.cs");
            while (!File.EndOfStream)
            {
                comment = File.ReadLine().Trim('/');
                if (comment[0] == ' '){
                    Console.WriteLine(comment);
                }
            }

            Console.ReadKey();
        }
    }
}
