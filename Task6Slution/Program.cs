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

        // New: store email and provide a Register method called by HandleCase6
        public string Email { get; set; }

        public void Register(string email)
        {
            // simple assignment; add validation if needed
            Email = email;
        }
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

        // Added: allow increasing stock quantity
        public void Restock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "Restock quantity must be positive.");
            StockQuantity += quantity;
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
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product & Stock Level Check");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale with Revenue");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("18. Overdrawn Account Check");
                Console.WriteLine("19. Set Student Security PIN");
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
                    case "6":
                        HandleCase6();
                        break;
                    case "7":
                        HandleCase7();
                        break;
                    case "8":
                        HandleCase8();
                        break;
                    case "9": 
                        //HandleCase9(); 
                        break;
                    case "10": 
                        //HandleCase10(); 
                        break;
                    case "11": 
                       // HandleCase11(); 
                        break;
                    case "12":
                       // HandleCase12(); 
                        break;
                    case "13":
                    // HandleCase13(); 
                    case "14":
                        //HandleCase14();
                        break;
                    case "15":
                        //HandleCase15();
                        break;
                    case "16": 
                        //HandleCase16();
                        break;
                    case "17":
                        //HandleCase17();
                        break;
                    case "18": 
                        //HandleCase18();
                        break;
                    case "19":
                        //HandleCase19();
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

        // Case 6 - Register a Student
        static void HandleCase6()
        {
            Console.WriteLine("1) " + student1.Name);
            Console.WriteLine("2) " + student2.Name);
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

            Console.Write("Enter email address: ");
            string emailInput = Console.ReadLine();
            selectedStu.Register(emailInput);

            Console.WriteLine("Confirmation: Student registration complete.");
        }

        // Case 7 - Compare Two Account Balances
        static void HandleCase7()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " has a higher balance than " + account2.HolderName + ".");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " has a higher balance than " + account1.HolderName + ".");
            }
            else
            {
                Console.WriteLine("Both account balances are equal.");
            }
        }

        // Case 8 - Restock Product & Stock Level Check
        static void HandleCase8()
        {
            Console.WriteLine("1) " + product1.ProductName + " (Current Stock: " + product1.StockQuantity + ")");
            Console.WriteLine("2) " + product2.ProductName + " (Current Stock: " + product2.StockQuantity + ")");
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

            Console.Write("Enter restock quantity: ");
            if (int.TryParse(Console.ReadLine(), out int qty))
            {
                selectedProd.Restock(qty);

                if (selectedProd.StockQuantity < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (selectedProd.StockQuantity >= 10 && selectedProd.StockQuantity <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }
            else
            {
                Console.WriteLine("Invalid numeric input.");
            }
        
        }

        // Case 9-Transfer Between Accounts
        static void HandleCase9()
        {
            Console.WriteLine("Select Source Account:");
            Console.WriteLine("1) " + account1.HolderName);
            Console.WriteLine("2) " + account2.HolderName);
            string srcInput = Console.ReadLine();
            BankAccount source = (srcInput == "1") ? account1 : ((srcInput == "2") ? account2 : null);

            Console.WriteLine("Select Destination Account:");
            Console.WriteLine("1) " + account1.HolderName);
            Console.WriteLine("2) " + account2.HolderName);
            string destInput = Console.ReadLine();
            BankAccount dest = (destInput == "1") ? account1 : ((destInput == "2") ? account2 : null);

            if (source == null || dest == null) { Console.WriteLine("Invalid account selected."); return; }
            if (source == dest) { Console.WriteLine("Source and destination cannot be the same."); return; }

            Console.Write("Enter transfer amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                if (source.Balance >= amount)
                {
                    source.Withdraw(amount);
                    dest.Deposit(amount);
                    Console.WriteLine("Transfer successful.");
                }
                else { Console.WriteLine("Failure: Insufficient balance in source account."); }
            }
            else { Console.WriteLine("Invalid numeric input."); }
        }

        // Case 10 - Update Student Grade
        static void HandleCase10()
        {
            Console.WriteLine("1) " + student1.Name + " (Current Grade: " + student1.Grade + ")");
            Console.WriteLine("2) " + student2.Name + " (Current Grade: " + student2.Grade + ")");
            Console.Write("Select Student (1 or 2): ");
            string input = Console.ReadLine();

            Student selectedStu = (input == "1") ? student1 : ((input == "2") ? student2 : null);
            if (selectedStu == null) { Console.WriteLine("Invalid selection."); return; }

            Console.Write("Enter new grade: ");
            if (int.TryParse(Console.ReadLine(), out int newGrade))
            {
                if (newGrade >= 0 && newGrade <= 100)
                {
                    selectedStu.Grade = newGrade;
                    Console.WriteLine("Grade updated to: " + selectedStu.Grade);
                }
                else { Console.WriteLine("Error: Grade must fall strictly within the 0-100 range."); }
            }
            else { Console.WriteLine("Error: Input is not a valid number."); }
        }

        // Case 11 - Student Report Card
        static void HandleCase11()
        {
            Console.WriteLine("1) " + student1.Name);
            Console.WriteLine("2) " + student2.Name);
            Console.Write("Select Student (1 or 2): ");
            string input = Console.ReadLine();

            Student selectedStu = (input == "1") ? student1 : ((input == "2") ? student2 : null);
            if (selectedStu == null) { Console.WriteLine("Invalid selection."); return; }

            string status = (selectedStu.Grade >= 60) ? "Pass" : "Fail";
            Console.WriteLine("\n--- REPORT CARD ---");
            Console.WriteLine("Name: " + selectedStu.Name);
            Console.WriteLine("Address: " + selectedStu.Address);
            Console.WriteLine("Grade: " + selectedStu.Grade + " (" + status + ")");
        }














    }
}
