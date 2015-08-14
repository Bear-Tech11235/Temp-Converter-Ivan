using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        { convert(); }

            static void convert() { 
            string unit;
            string temp;
            int tempvalue = 0;
            string f = "F";
            string c = "C";
                Console.WriteLine("Would you like to convert from Fahrenheit or Celcius? Please enter a 'C' or an 'F'.");
                unit = Console.ReadLine();
                unit = unit.ToUpper();
            if (Equals(unit, c) || Equals(unit, f)) 
                {       
                    Console.WriteLine("Please enter a temperature to convert");
                    temp = Console.ReadLine();
                // if tempvalue = (Int32.TryParse(temp, out tempvalue));
                //{ tempvalue = (Int32.Parse(temp, out tempvalue)); }
                tempvalue = Convert.ToInt32(temp);
                if (Equals(unit, c)) 
                {
                    tempvalue = (tempvalue - 32) * (5 / 9);
                    Console.WriteLine(tempvalue);
                    Console.ReadLine();
                }
                }
                else
                {
                    Console.WriteLine("You have not entered a valid unit of measurement. Press any key to continue.");
                    temp = Console.ReadLine();
                    convert();
                }
        }
    }
}
