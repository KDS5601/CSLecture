using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");
            Console.Write('\n');

            string myString = "Hello World!";

            Console.WriteLine(myString);

            char[] myCharList = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };

            Console.WriteLine(myCharList);            

            Console.ReadKey();
        }
    }
}
