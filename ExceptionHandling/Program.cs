using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    //An exception happens when a problem occours during a program excecution
    //this generally will cause an abnormal termination of the program
    //A well written program sould be able to handle exceptions

    class Program
    {

        static void Main(string[] args)
        {
            //the following 2 lines will cause an exception
            int[] arr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(arr[8]);

            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
