﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 11;
            //Additon
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //Multiplication
            int product = a * b;
            Console.WriteLine(product);

            //Division
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = b % a;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1842, 1, 1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);

            //Comparison Operators
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();

            bool equals = age == 41;
            bool userIs = username == "Frank";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Frank: " + userIs);

            bool notEqual = age != 113;
            bool userIsNot = username != "Justin";
            Console.WriteLine($"User is not 113: {notEqual}");
            Console.WriteLine($"User is not Justin: {userIsNot}");

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;

            bool orValue = equals || lessThan;
            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            bool andValue = greaterThan && orValue;
            bool tAndT = true && true;

            int x = 3;
            bool test = x < 44 && x > 10;
            Console.WriteLine(test);



            Console.ReadKey();
        }
    }
}
