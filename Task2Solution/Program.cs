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

            //2- Sum Of Nambers 1 to N
            // Some Code To Solove The Task

            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            Console.WriteLine("The final sum is:" + total);
            
            //////////////////////////////////////////////////////



















        }
    }
         
}
