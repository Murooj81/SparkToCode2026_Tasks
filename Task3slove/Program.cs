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





































        }
    }
}
