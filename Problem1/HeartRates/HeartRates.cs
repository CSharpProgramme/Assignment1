using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class HeartRates
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear;

        public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = currentYear;
        }

        public string FirstName 
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string LastName 
        { 
            get { return lastName; } 
            set { this.lastName = value; }
        }
        public int BirthYear 
        { 
            get { return birthYear;}
            set { this.birthYear = value; }
        }
        public int CurrentYear 
        {   get { return currentYear;}
            set { this.currentYear = value; }
        }


        public int Age
        {
            get { return CurrentYear - BirthYear; }
        }

        public int MaximumHR
        {
            get { return 220 - Age; }
        }

        public int MinimumTargetHR
        {
            get { return (int) (MaximumHR * 0.50); }
        }

        public int MaximumTargetHR
        {
            get { return (int)(MaximumHR * 0.85); }
        }

        public void DisplayPatientRecord()
        {
            string fullname = LastName + ", " + FirstName;
            string heartRatetarget = MinimumTargetHR + "-" + MaximumTargetHR;

            drawLine();
            Console.WriteLine($"| {"PATIENT HEART RATE RECORD",50}  {"|",27}");
            drawLine();
            Console.WriteLine($"| {"Patient Name",-25} | {fullname,-49} |");
            drawLine();
            Console.WriteLine($"| {"Patient Birth Year",-25} | {BirthYear,49} |");
            drawLine();
            Console.WriteLine($"| {"Patient Age",-25} | {Age,49} |");
            drawLine();
            Console.WriteLine($"| {"Maximum Heart Rate",-25} | {MaximumHR,49} |");
            drawLine();
            Console.WriteLine($"| {"Target Heart Rate Range",-25} | {heartRatetarget,49} |");
            drawLine();
        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 79; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");
        }
    }
}
