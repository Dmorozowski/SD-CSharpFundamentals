using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisIsDeclaration;

            string declared;
            declared = "This is initialized";

            string declarationAndInitialization = "This is both declaring and initializing";

            //Lists
            List<string> listOfString = new List<string>();
            List<int> listOfInt = new List<int>();
            listOfString.Add("First string of our list");
            listOfInt.Add(4242);
            listOfInt.Add(12345);

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            Console.WriteLine(listOfInt[0]);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //Other Collection Examples
            SortedList<int, string> sortedAndKeyValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);


            Console.ReadKey();

        }
    }
}
