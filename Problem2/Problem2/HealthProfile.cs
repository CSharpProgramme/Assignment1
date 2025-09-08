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
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Height = height;
            Weigth = weigth;
            CurrentYear = currentYear;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public double Height { get; set; }
        public double Weigth { get; set; }
        public int CurrentYear { get; set; }


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

        public int BodyMassIndex()
        {
            return (int)((Weigth * 703) / (Math.Pow(Height, 2.0)));
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
                return "Overweigth";
            }
            else
            {
                return "Obese";
            }
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("PATIENT HEAlTH RECORD");
            Console.WriteLine("──────────────────────────");
            Console.WriteLine($"{"Patient Name",-25} {LastName}, {FirstName}");
            Console.WriteLine($"{"Patient Birth Year",-25} {BirthYear}");
            Console.WriteLine($"{"Patient Age",-25} {Age}");
            Console.WriteLine($"{"Maximum Heart Rate",-25} {MaximumHR}");
            Console.WriteLine($"{"Target Heart Rate Range",-25} {MinimumTargetHeartRate}—{MaximumTargetHeartRate}");
            Console.WriteLine($"{"BMI Numeric Value",-25} {BodyMassIndex()}");
            Console.WriteLine($"{"BMI Text Value",-25} {BMITextValue()}");
            Console.WriteLine();
        }
    }
}
