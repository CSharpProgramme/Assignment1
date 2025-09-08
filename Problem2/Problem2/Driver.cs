using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter your birth year name: ");
            int bYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in inches (in): ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weigth in pounds(lbs): ");
            int weigth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the current year name: ");
            int cYear = int.Parse(Console.ReadLine());


            HealthProfile myHealthProfile = new HealthProfile(fName, lName, bYear, height, weigth, cYear);
            myHealthProfile.DisplayPatientRecord();

        }
    }
}
