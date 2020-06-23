using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int total = 1;
            while(total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("You did it!");
                    break;
                }
                total++;
            }

            Random random = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = random.Next(0,20);
                if(someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            //For Loop
            int studentCount = 21;
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Nick", "AJ", "Dylan", "Severa", "Tim" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there! {students[i]}!");

            }

            //For Each
            foreach (string student in students)
            {
                Console.WriteLine(student + " is in the class today!");
            }

            string myName = "Dylan Morozowski";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            //Do While Loop
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            Console.ReadKey();
        }
    }
}
