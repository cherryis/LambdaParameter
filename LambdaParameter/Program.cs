using System;
using static System.Console;
namespace LambdaParameter
{
    class Program
    {
        //Declare the delegate
        public delegate void Del(string s);

        static void Main(string[] args)
        {
            //Just print something using the predefined method
            Del handler = new Del(DelegateMethod1);  //Instantiate a named delegate
            PrintIt("Hello world!", handler);

            //Creating a function with a lambda
            Write("\nEnter something to print: ");
            Del reusableHandler = (inString) => WriteLine(inString);
            reusableHandler(ReadLine());


            //But you don't have to create anything.  You can just pass in the lambda exrpession!
            Write("\nEnter something else to print: ");
            PrintIt(ReadLine(), (inString) => WriteLine(inString));

            ReadKey();
        }

        public static void PrintIt(string myString, Del Writer)
        {
            Writer(myString);
        }
        public static void DelegateMethod1(string message)
        {
            WriteLine(message);
        }

    }
}
