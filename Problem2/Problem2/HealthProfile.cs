using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class HealthProfile
    {
        //ATTRIBUTES
        private string firstName;
        private string lastName;
        private int birthYear;
        private double height;
        private double weigth;
        private int currentYear;

        //CONSTRUCTOR
        public HealthProfile(string firstName, string lastName, int birthYear, double height, double weigth, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Height = height;
            Weight = weigth;
            CurrentYear = currentYear;
        }

        //PROPERTIES WITH GETTERS AND SETTERS
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
            set {
                if (value >= 1900)
                    birthYear = value;
                else
                {
                    Console.WriteLine("Invalid birth year");
                    birthYear = 1900;
                }
            }
        }
        public double Height 
        { 
            get { return height;}
            set { 
                if(value >= 12 && value <= 96)
                    height = value;
                else
                {
                    Console.WriteLine("Invalid Height");
                    height = 12;
                }
            }
        }
        public double Weight
        { 
            get { return weigth; }
            set {
                if(value >= 5 && value <= 1400)
                    weigth = value;
                else
                {
                    Console.WriteLine("Invalid Weigth");
                    weigth = 120;
                }
            }
        }
        public int CurrentYear 
        { 
            get { return currentYear;}
            set { this.currentYear = value; }
        }

        //READ-ONLY PROPERTIES
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
            get { return (int)(MaximumHR * 0.50); }
        }

        public int MaximumTargetHR
        {
            get { return (int)(MaximumHR * 0.85); }
        }

        //METHODS
        //method to find the patient's body mass index
        public double BodyMassIndex()
        {
            return Math.Round((Weight * 703) / (Math.Pow(Height, 2.0)), 2);
        }

        //method to find the patient's BMI text value
        public string BMITextValue()
        {
            double bmi = BodyMassIndex();
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        //METHOD TO DISPLAY THE PATIENT RECORD TABLE
        public void DisplayPatientRecord()
        {
            string fullname = LastName + ", " + FirstName;
            string heartRatetarget = MinimumTargetHR + "-" + MaximumTargetHR;

            drawLine();
            Console.WriteLine($"| {"PATIENT HEAlTH RECORD",50}  {"|",27}");
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
            Console.WriteLine($"| {"BMI Numeric Value",-25} | {BodyMassIndex(),49} |");
            drawLine();
            Console.WriteLine($"| {"BMI Text Value",-25} | {BMITextValue(),-49} |");
            drawLine();
        }

        //HELPER METHOD
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
