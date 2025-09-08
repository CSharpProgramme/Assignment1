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

        public string FirstName { get; set; }

        public string LastName {  get; set; }

        public int BirthYear { get; set; }

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
            get { return (int) (MaximumHR * 0.50); }
        }

        public int MaximumTargetHeartRate
        {
            get { return (int)(MaximumHR * 0.85); }
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("PATIENT HEART RATE RECORD");
            Console.WriteLine("──────────────────────────");
            Console.WriteLine($"{"Patient Name",-25} {LastName}, {FirstName}");
            Console.WriteLine($"{"Patient Birth Year",-25} {BirthYear}");
            Console.WriteLine($"{"Patient Age",-25} {Age}");
            Console.WriteLine($"{"Maximum Heart Rate",-25} {MaximumHR}");
            Console.WriteLine($"{"Target Heart Rate Range",-25} {MinimumTargetHeartRate}—{MaximumTargetHeartRate}");
            Console.WriteLine();
        }
    }
}
