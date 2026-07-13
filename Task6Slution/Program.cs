using System;

namespace Task6Slution
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            if (amount > Balance) return false;
            Balance -= amount;
            return true;
        }

        public override string ToString() => $"#{AccountNumber} {HolderName} - Balance: {Balance}";
    }

    internal class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
    }

    internal class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
    }

    internal class Program
    {
        static BankAccount account1;
        static BankAccount account2;
        static Student student1;
        static Student student2;
        static Product product1;
        static Product product2;

        static void Main(string[] args)
        {
            account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "karim";
            account1.Balance = 120;

            account2 = new BankAccount();
            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            student1 = new Student();
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;

            student2 = new Student();
            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;

            product1 = new Product();
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            product2 = new Product();
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("20. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleCase1();
                        break;
                    case "2":
                        HandleCase2();
                        break;
                    case "3":
                        HandleCase3();
                        break;
                    case "4":
                        HandleCase4();
                        break;
                    case "5":
                        HandleCase5();
                        break;
                    case "20":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(" Invalid option.");
                        break;
                }
            }
        }

        
        static void HandleCase1()
        {
            Console.WriteLine("\nAccount 1:");
            Console.WriteLine($"#{account1.AccountNumber} {account1.HolderName} - Balance: {account1.Balance}");
            Console.WriteLine("\nAccount 2:");
            Console.WriteLine($"#{account2.AccountNumber} {account2.HolderName} - Balance: {account2.Balance}");
        }

        
        static void HandleCase2()
        {
            Console.Write("Select student (1 or 2): ");
            var sel = Console.ReadLine();
            Student s = sel == "1" ? student1 : sel == "2" ? student2 : null;
            if (s == null)
            {
                Console.WriteLine(" Invalid student selection.");
                return;
            }

            Console.Write("Enter new address: ");
            var newAddr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newAddr))
            {
                Console.WriteLine("Address cannot be empty.");
                return;
            }

            s.Address = newAddr;
            Console.WriteLine($"Updated: {s.Name} - Address: {s.Address}");
        }

        static void HandleCase3()
        {
            Console.Write("Select account (1 or 2): ");
            var sel = Console.ReadLine();
            BankAccount acc = sel == "1" ? account1 : sel == "2" ? account2 : null;
            if (acc == null)
            {
                Console.WriteLine("Invalid account selection.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            try
            {
                acc.Deposit(amount);
                Console.WriteLine($"Deposited {amount}. New balance: {acc.Balance}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Amount must be positive.");
            }
        }

        // Withdraw from selected account (1 or 2)
        static void HandleCase4()
        {
            Console.Write("Select account (1 or 2): ");
            var sel = Console.ReadLine();
            BankAccount acc = sel == "1" ? account1 : sel == "2" ? account2 : null;
            if (acc == null)
            {
                Console.WriteLine("Invalid account selection.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            try
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrawn {amount}. New balance: {acc.Balance}");
                else
                    Console.WriteLine("Insufficient funds.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Amount must be positive.");
            }
        }

        // Displays product details
        static void HandleCase5()
        {
            Console.WriteLine("\nProduct 1:");
            Console.WriteLine($"{product1.ProductName} - Price: {product1.Price} - Stock: {product1.StockQuantity}");
            Console.WriteLine("\nProduct 2:");
            Console.WriteLine($"{product2.ProductName} - Price: {product2.Price} - Stock: {product2.StockQuantity}");
        }
    }
}