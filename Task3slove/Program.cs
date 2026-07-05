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

            //5. rade Rounding System

            Console.Write("Enter your raw exam score (decimal): ");
            double rawScore = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(rawScore, 0);
            Console.WriteLine($"Rounded Score: {roundedScore}");

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            //////////////////////////////////////////////////////////////

            //6- Password Strength Checker

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool isLongEnough = password.Length >= 8;
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (isLongEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Password Strength: Strong");
            }
            else
            {
                Console.Write("Password Strength: Weak. Reason: ");
                if (!isLongEnough && containsForbiddenWord)
                {
                    Console.WriteLine("It is less than 8 characters long and contains the forbidden word 'password'.");
                }
                else if (!isLongEnough)
                {
                    Console.WriteLine("It must be at least 8 characters long.");
                }
                else
                {
                    Console.WriteLine("It cannot contain the word 'password'.");
                }
            }

            ///////////////////////////////////////////////////////////////

            //7- Clean Name Comparator

            Console.Write("Enter the name the first time: ");
            string firstInput = Console.ReadLine();

            Console.Write("Enter the name the second time: ");
            string secondInput = Console.ReadLine();

            string cleanFirst = firstInput.Trim().ToUpper();
            string cleanSecond = secondInput.Trim().ToUpper();

            if (cleanFirst == cleanSecond)
            {
                Console.WriteLine("Result: Match");
            }
            else
            {
                Console.WriteLine("Result: No Match");
            }
            
            //////////////////////////////////////////////////////////////
            

















        }
    }
}
