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

        internal double CheckBalance()
        {
            return Balance;
        }
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

        public double GetInventoryValue()
        {
            return Price * StockQuantity;
        }
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

        // Case 1 – View Account Details
        static void HandleCase1()

        {
            Console.WriteLine("1) " + account1.HolderName + " (Acc: " + account1.AccountNumber + ")");
            Console.WriteLine("2) " + account2.HolderName + " (Acc: " + account2.AccountNumber + ")");
            Console.Write("Select Account (1 or 2): ");
            string input = Console.ReadLine();

            BankAccount selectedAcc = null;
            if (input == "1") selectedAcc = account1;
            else if (input == "2") selectedAcc = account2;

            if (selectedAcc == null)
            {
                Console.WriteLine(" Invalid selection.");
                return;
            }

            double returnedBalance = selectedAcc.CheckBalance();
            Console.WriteLine("Returned Value: " + returnedBalance.ToString("F3"));
        }

        // Case 2 – Update Student Address
        static void HandleCase2()
        {
            Console.WriteLine("1) " + student1.Name + " (" + student1.Address + ")");
            Console.WriteLine("2) " + student2.Name + " (" + student2.Address + ")");
            Console.Write("Select Student (1 or 2): ");
            string input = Console.ReadLine();

            Student selectedStu = null;
            if (input == "1") selectedStu = student1;
            else if (input == "2") selectedStu = student2;

            if (selectedStu == null)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            selectedStu.Address = newAddress;

            Console.WriteLine("Confirmation: " + selectedStu.Name + "'s new address is " + selectedStu.Address);
        }

        // Case 3 – Make a Deposit
        static void HandleCase3()
        {
            Console.WriteLine("1) " + account1.HolderName + " (Acc: " + account1.AccountNumber + ")");
            Console.WriteLine("2) " + account2.HolderName + " (Acc: " + account2.AccountNumber + ")");
            Console.Write("Select Account (1 or 2): ");
            string input = Console.ReadLine();

            BankAccount selectedAcc = null;
            if (input == "1") selectedAcc = account1;
            else if (input == "2") selectedAcc = account2;

            if (selectedAcc == null)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                selectedAcc.Deposit(amount);
                Console.WriteLine("Holder Name: " + selectedAcc.HolderName + " | Updated Balance: " + selectedAcc.Balance.ToString("F3"));
            }
            else
            {
                Console.WriteLine("Invalid numeric input.");
            }
        }

        // Case 4 – Make a Withdrawal
        static void HandleCase4()
        {
            Console.WriteLine("1) " + account1.HolderName + " (Acc: " + account1.AccountNumber + ")");
            Console.WriteLine("2) " + account2.HolderName + " (Acc: " + account2.AccountNumber + ")");
            Console.Write("Select Account (1 or 2): ");
            string input = Console.ReadLine();

            BankAccount selectedAcc = null;
            if (input == "1") selectedAcc = account1;
            else if (input == "2") selectedAcc = account2;

            if (selectedAcc == null)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                selectedAcc.Withdraw(amount);
                Console.WriteLine("Updated Balance: " + selectedAcc.Balance.ToString("F3"));
            }
            else
            {
                Console.WriteLine("Invalid numeric input.");
            }
        }

        // Case 5 – View Product Details
        static void HandleCase5()
        {
            Console.WriteLine("1) " + product1.ProductName);
            Console.WriteLine("2) " + product2.ProductName);
            Console.Write("Select Product (1 or 2): ");
            string input = Console.ReadLine();

            Product selectedProd = null;
            if (input == "1") selectedProd = product1;
            else if (input == "2") selectedProd = product2;

            if (selectedProd == null)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            double totalInventoryValue = selectedProd.GetInventoryValue();
            Console.WriteLine("Total Value: " + totalInventoryValue.ToString("F3"));
     
        }
    
    
    
    
    
    
    
    
    

    }
}

