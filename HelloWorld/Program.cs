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

            int myInt = 13;
            Console.WriteLine(myInt);

            int[] myIntList = { 72, 101, 108, 108, 111, 32, 87, 111, 114, 101, 100, 33 };
            for (int i = 0; i < myIntList.Length - 1; ++i)
            {
                Console.Write(myIntList[i] + " ");
            }
            Console.Write('\n');
            
            for(int i = 0; i < myIntList.Length - 1; ++i)
            {
                myCharList[i] = (char)myIntList[i];
            }
            Console.WriteLine(myCharList);

            Console.ReadKey();
        }
    }
}
