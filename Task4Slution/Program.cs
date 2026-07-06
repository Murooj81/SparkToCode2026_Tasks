namespace Task4Slution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Personalized Welcome Function

            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();

            // Call the function
            PrintWelcome(nameInput);
        }

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome back, " + name + "! Have a fantastic learning session.");


            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 2 - Square Number Function

            Console.Write("Enter an integer to square: ");
            int input = int.Parse(Console.ReadLine());

            int result = Square(input);
            Console.WriteLine("The squared result is: " + result);
        }

        static int Square(int number)
        {
            return number * number;

            ////////////////////////////////////////////////////////////////////////////////

            //Task 3 - Celsius to Fahrenheit Function


            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;











































































































        }
    }
}
