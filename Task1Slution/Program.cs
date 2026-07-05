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


















































        }
    }
}
