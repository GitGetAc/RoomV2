namespace RoomV2
{
    internal class House
    {
        private List<Floor> Floors { get; set; }
        private Floor currentFloor = new(); 

        public House()
        {
            Floors = [];
        }

        //1 Floor type (list of rooms)
        public void AddFloor(Floor floor) 
        {
            Floors.Add(floor);
        }

        public void BuildAHouse() 
        {
            Console.WriteLine("A house contains 1 or more floors, ");
            Console.WriteLine("each floor must contain 5 rooms, ");
            Console.WriteLine("Max. 1 kitchen/bedroom floor.\n");

            Console.Write("Enter how many floors do you want to have: ");

            int FloorNumber = Convert.ToInt16(Console.ReadLine());

            while (Floors.Count < FloorNumber)
            {
                Console.Write("Enter a room type 'livingroom' 'bedroom' 'kitchen' 'bathroom':");

                string RoomType = Console.ReadLine()!;

                Console.Write("Enter the room color: ");

                string Roomcolor = Console.ReadLine()!;

                currentFloor.AddRoom(new Room(RoomType, Roomcolor));
                
                if(currentFloor.Rooms.Count == 5) 
                {
                    AddFloor(currentFloor);
                    Console.WriteLine("New floor added!");
                    currentFloor = new();
                }
            }
        }

        public void PrintOutHouse()
        {
            Console.WriteLine("The house contains:");

            for(int i = 0; i < Floors.Count; i++)
            {
                Console.WriteLine($"Floor {i+1} contains: ");

                foreach  (Room r in Floors[i].Rooms)
                {
                    Console.WriteLine($"A {r.Color} {r.Type}");
                }
            }
            Console.WriteLine("The house is finished!");
        }
    }
}
