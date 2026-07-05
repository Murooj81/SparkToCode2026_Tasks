namespace Task3slove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Absolute Difference

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = num1 - num2;
            double absoluteDifference = Math.Abs(difference);

            Console.WriteLine($"The absolute difference is: {absoluteDifference}");

            //////////////////////////////////////////////////////////////////////////


            //2. Power & Root Explorer

            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine($"Square (power of 2): {square}");
            Console.WriteLine($"Square root: {squareRoot}");

            ///////////////////////////////////////////////////////////////////

            //3. Name Formatter

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Character count: {fullName.Length}");

            ///////////////////////////////////////////////////////////////

            //4. Subscription Enf Data 

            Console.Write("Enter the number of free trial days: ");
            int trialDays = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(trialDays);

            Console.WriteLine($"The trial ends on: {endDate.ToString("yyyy-MM-dd")}");

            ///////////////////////////////////////////////////////////////////
            




















        }
    }
}
