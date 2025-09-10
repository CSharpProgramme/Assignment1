using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class HealthProfile
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private double height;
        private double weigth;
        private int currentYear;


        public HealthProfile(string firstName, string lastName, int birthYear, double height, double weigth, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.height = height;
            this.weigth = weigth;
            this.currentYear = currentYear;
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
        public double Height 
        { 
            get { return height;}
            set { this.height = value; }
        }
        public double Weigth 
        { 
            get { return weigth;}
            set { this.weigth = value; }
        }
        public int CurrentYear 
        { 
            get { return currentYear;}
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
        public int MinimumTargetHeartRate
        {
            get { return (int)(MaximumHR * 0.50); }
        }

        public int MaximumTargetHeartRate
        {
            get { return (int)(MaximumHR * 0.85); }
        }

        public double BodyMassIndex()
        {
            return Math.Round((Weigth * 703) / (Math.Pow(Height, 2.0)), 2);
        }

        public string BMITextValue()
        {
            if (BodyMassIndex() < 18.5)
            {
                return "Underweight";
            }
            else if (BodyMassIndex() >= 18.5 && BodyMassIndex() <= 24.9)
            {
                return "Normal";
            }
            else if (BodyMassIndex() >= 25 && BodyMassIndex() <= 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        public void DisplayPatientRecord()
        {
            string fullname = LastName + ", " + FirstName;
            string heartRatetarget = MinimumTargetHeartRate + "-" + MaximumTargetHeartRate;

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
