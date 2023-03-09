using System;

namespace Operators_Upton_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Initializes an integer that multipies two integers
            int intMult = 6 * 45;
            // Initalized an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maximum and minumum of the two integer varibals
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}");

            // Initailized boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}");

            
            // Initializes an short that multipies two short
            short shortMult = 6 * 45;
            // Initalized an short that adds to short
            short shortAdd = 55 + 66;
            // Prshorts the maximum and minumum of the two short varibals
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            // Initailized boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");
       
            // Initializes an long that multipies two long
            long  longMult = 6 * 45;
            // Initalized an long that adds to long
            long  longAdd = 55 + 66;
            // Prints the maximum and minumum of the two long eger varibals
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The min of the two is {Math.Min(longMult, longAdd)}");

            // Initailized boolean to see if long Mult is greater than long Add
            bool islongGreater = longMult > longAdd;
            // Prints if long Mult is greater than long Add
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");


            // Initializes an float that multipies two float
            float floatMult = 6.5f * 45.24f;
            // Initalized an float that adds to float
            float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minumum of the two float varibals
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            // Initailized boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}");


            // Initializes an double that multipies two double
            double doubleMult = 6.69 * 45.58;
            // Initalized an double that adds to double
            double doubleAdd = 55.48 + 66.15;
            // Prints the maximum and minumum of the two double varibals
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Initailized boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}");


            // Initializes an decimal that multipies two decimal
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Initalized an decimaleger that adds to decimalegers
            decimal decimalAdd = (decimal)(55.66 + 66.55);
            // Prints the maximum and minumum of the two decimaleger varibals
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Initailized boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}");
        }
    }
}
