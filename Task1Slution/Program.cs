using System.Drawing;

namespace Task1Slution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Personal Info Card

            String name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hight: " + height);
            Console.WriteLine("Student: " + isStudent);

            ////////////////////////////////////////////////

            //Task 2 - Rectangle Calculator

            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            ////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker

            Console.Write("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }

            ///////////////////////////////////////////////////

            //Task 4 - Voting Eligibility

            Console.Write("Enter your age: ");
            int votingAge = int.Parse(Console.ReadLine());

            Console.Write("Do you hold a valid national ID? (yes/no): ");
            string idInput = Console.ReadLine().ToLower();

            bool hasValidId = (idInput == "yes");

            if (votingAge >= 18 && hasValidId)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            //////////////////////////////////////////////////////

















































        }
    }
}
