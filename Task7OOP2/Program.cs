namespace Task7OOP2
{

    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, string roomType, double pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = true;
        }

        public void DisplayRoom()
        {
            string status = IsAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room #{RoomNumber} | Type: {RoomType} | Price: OMR {PricePerNight:F2} | [{status}]");
        }
    }

    internal class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = "Not Assigned";
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine($"ID: {GuestId,-5} | Name: {GuestName,-12} | Room: {RoomNumber,-12} | Check-in: {CheckInDate,-10} | Nights: {TotalNights}");
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return TotalNights * pricePerNight;
        }
    }

    // Main Program
    internal class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {
           
            rooms.Add(new Room(101, "Single", 25.00));
            rooms.Add(new Room(102, "Single", 25.00));
            rooms.Add(new Room(201, "Double", 45.00));
            rooms.Add(new Room(202, "Double", 45.00));
            rooms.Add(new Room(301, "Suite", 90.00));
            rooms.Add(new Room(302, "Suite", 120.00));

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\n--- GRAND VISTA HOTEL MANAGEMENT SYSTEM ---");
                Console.WriteLine("1. Add New Room                 9. Guest Lookup by Name");
                Console.WriteLine("2. Register New Guest          10. Room Type Breakdown Report");
                Console.WriteLine("3. Book a Room for a Guest     11. Check Out a Guest");
                Console.WriteLine("4. View All Rooms              12. Remove Unavailable Rooms");
                Console.WriteLine("5. View All Guests             13. Extend Guest Stay");
                Console.WriteLine("6. Search & Filter Rooms       14. Highest Revenue Booking");
                Console.WriteLine("5. Guest Pagination Viewer     0. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        //AddRoom(); 
                        break;
                    case "2": 
                       // RegisterGuest(); 
                        break;
                    case "3":
                       // BookRoom();
                        break;
                    case "4":
                       // ViewAllRooms(); 
                        break;
                    case "5": 
                        //ViewAllGuests();
                        break;
                    case "6":
                       // FilterRoomsMenu();
                        break;
                    case "7":
                        //ShowStatistics(); 
                        break;
                    case "8": 
                        //UpdatePrice(); 
                        break;
                    case "9": 
                       // SearchGuestByName(); 
                        break;
                    case "10": 
                       // TypeBreakdownReport();
                        break;
                    case "11": 
                       // CheckOutGuest();
                        break;
                    case "12": 
                       // DeleteUnavailableRooms();
                        break;
                    case "13":
                       // ExtendStay(); 
                        break;
                    case "14": 
                       // HighestRevenueBooking();
                        break;
                    case "15":
                      //  PaginateGuests();
                        break;
                    case "0": loop = false; Console.WriteLine("Exiting program.");
                        break;
                    default: Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }

        }
    }































































































}

