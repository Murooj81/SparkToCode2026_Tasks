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




















































        }
    }
}
