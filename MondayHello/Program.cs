// Using statements tell the compiler where to find the class definitions needed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayHello  // Defines the "root name" of the classes and functions found here
{ 
    class Program  // this inherits from class program
    {
        static void Main(string[] args) // the main function is where the program starts running
                                        // command line parameters are input here
        {

            Console.WriteLine("Hello " + args[0] + " " + args[1]);  // as input
            Console.WriteLine("Hello " + args[1] + ", " + args[0]);  // in last,first order


            Console.ReadLine();
        }
    }
}
