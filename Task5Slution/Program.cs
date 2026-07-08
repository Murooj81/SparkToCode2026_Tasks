namespace Task5Slution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Fixed Grades Array

            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nStudent Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 2 - Dynamic To-Do List

            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                tasks.Add(Console.ReadLine());
            }

            Console.WriteLine("\nTo-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///

            //Task 3 - Browsing History Stack

            Stack<string> browserHistory = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL: ");
                browserHistory.Push(Console.ReadLine());
            }

            string lastPage = browserHistory.Pop();

            Console.WriteLine("\nBack button pressed.");
            Console.WriteLine("Removed page: " + lastPage);

            Console.WriteLine("Current page:");

            if (browserHistory.Count > 0)
            {
                Console.WriteLine(browserHistory.Peek());
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 4 – Customer Service Queue

            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name: ");
                customers.Enqueue(Console.ReadLine());
            }

            Console.WriteLine();

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Served Customer: " + servedCustomer);

            Console.WriteLine("\nRemaining Customers:");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 5 – Array Grade Range

            _ = new int[5];
            int sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            double average = (double)sum / grades.Length;

            Console.WriteLine("\nLowest Grade : " + grades[0]);
            Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            Console.WriteLine("Average      : " + average);

            ///////////////////////////////////////////////////////////////////////////////
            ///


















































        }
    }
}
