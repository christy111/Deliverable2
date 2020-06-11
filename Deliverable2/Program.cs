using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a word to encode");

            //Declare Variables and convert input to upper case
            string input = (Console.ReadLine()).ToUpper();
            string message = "";
            int checksum = 0;
            int unival;

            //Find Unicode value
            foreach (char c in input)
            {
                unival = ((int)c);

                //add unicode value for each letter into checksum
                checksum += unival;

                //add encoded letter to message string followed by dash 

                message += unival - 64 + "-";
            }
                Console.WriteLine("Input is " + message);
                Console.WriteLine("Checksum is " + checksum);                    
            

        }
    }
}
