using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_GroupAssignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PATIENT'S DETAILS....");

            // asking the user to enter the age

            Console.Write("ENTER YOUR AGE:- ");
            int age = Convert.ToInt32(Console.ReadLine());

            // asking the user to input his personal details

            Console.WriteLine("\nENTER THE DETAILS OF PATIENT:-");
            Console.Write("FIRST NAME:- ");
            string firstName = Console.ReadLine();
            Console.Write("LAST NAME:- ");
            string lastName = Console.ReadLine();
            Console.Write("WEIGHT (KG):- ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("HEIGHT (CM):- ");
            double height = Convert.ToDouble(Console.ReadLine());

            // creating an object patient based on his input

            Patient patient = new Patient(firstName, lastName, weight, height);

            // print patient details

            patient.PrintPatientDetails();

            Console.ReadLine();
        }
    }
}