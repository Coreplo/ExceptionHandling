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

            Console.WriteLine("Exception Handling");

            //the following 2 lines will cause an exception
            //int[] arr = new int[] { 1, 2, 3, 4 };
            //Console.WriteLine(arr[8]);

            //try catch
            try
            {
                int[] arr = new int[] {1,2,3,4 };
                Console.WriteLine(arr[7]);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Me Go Fa To Er Ro Re");
            }


            //multiple catches

            int x;
            int y;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by 0 exception occoured");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception");
                Console.WriteLine(e.Message);
            }

            //Some of the most common exceptions are

            //FileNotFoundException, 
            //FormatException, 
            //IndexOutOfRangeException, 
            //InvalidOperationException, 
            //OutOfMemoryException.

            //more here
            //https://www.completecsharptutorial.com/basic/complete-system-exception.php


            //  ---finally---
            // finally block runs whether a catch block is run or not
            //eg when working with files close file whether it has been written or not


            int result = 14;
            int num1 = 8;
            int num2 = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine(result);
            }


            Console.ReadKey();

        }
    }
}
