using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            char character = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n';

            //Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;


            int a = 7;
            int b = -7000;

            byte age = 104;

            //Decimals
            float floatExample = 1.045231f;
            double doubleExample;
            decimal decimalExample;

            Console.WriteLine();
        }
    }
}
