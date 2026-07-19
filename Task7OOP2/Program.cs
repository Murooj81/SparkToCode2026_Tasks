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


















































}

