using System.Runtime.InteropServices;

namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Countdown Timer
            // Some Code To Solove The Task

            Console.WriteLine("Enter the countdown time: ");
            int countdownTime = int.Parse(Console.ReadLine());
             
            for (int i = countdownTime; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);


            }
            Console.WriteLine("Countdown finished!");

            ///////////////////////////////////////////////////





















        }
    }
         
}
