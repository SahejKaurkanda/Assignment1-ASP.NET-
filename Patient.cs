using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_GroupAssignment_1
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in kg
        public double Height { get; set; } // in cm

        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        public string BLOODPRESSURE(int systolic, int diastolic)
        {
            if (systolic < 90 || systolic > 200 || diastolic < 60 || diastolic > 120)
            {
                return " Your Blood Pressure is not in the range!! Consult the Doctor Immediately!!";
            }
            else if (systolic <= 120 && diastolic <= 80)
            {
                return "Normal";
            }
            else if (systolic <= 129 && diastolic <= 84)
            {
                return "Elevated";
            }
            else if (systolic <= 139 && diastolic <= 89)
            {
                return "High Blood Pressure (Hypertension) Stage 1";
            }
            else if (systolic <= 180 && diastolic <= 120)
            {
                return "High Blood Pressure (Hypertension) Stage 2";
            }
            else
            {
                return "Hypertensive Crisis. Consult your doctor immediately!!";
            }
        }

        public double BMI()
        {
            double heightInMeter = Height / 100; // conversion of height from cm to m
            return Weight / (heightInMeter * heightInMeter);
        }

        public void PrintPatientDetails()
        {
            Console.WriteLine("PATIENT DETAILS");
            Console.WriteLine("FULL NAME:- {0} {1}", FirstName, LastName);
            Console.WriteLine("WEIGHT:- {0} kg", Weight);
            Console.WriteLine("HEIGHT:- {0} cm", Height);
            Console.WriteLine("BLOOD PRESSURE:- {0}", BLOODPRESSURE(120, 80));
            Console.WriteLine("BMI-: {0}", BMI());

            double bmi = BMI();
            if (bmi >= 25.0)
            {
                Console.WriteLine("BMI STATUS:- Overweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI STATUS:- Normal (Healthy Range)");
            }
            else
            {
                Console.WriteLine("BMI STATUS:- UnderWeight");
            }
        }
    }

}