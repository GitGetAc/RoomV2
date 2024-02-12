namespace RoomV2
{
    internal class Floor
    {
        public List<Room> Rooms { get; set; }

        public Floor()
        {
            Rooms = [];
        }

        //1 room (nem a lista)
        public void AddRoom(Room room)
        {
            if(room.Type == "kitchen" || room.Type == "livingroom" || room.Type == "bathroom" || room.Type == "bedroom")
            {
                if (room.Type == "livingroom" || room.Type == "bedroom")
                {
                    Rooms.Add(room);
                }
                //Ha a Rooms lista NEM tartalmaza a kitchen, bathroom room.Tpe-ot
                else if (!Rooms.Any(r => r.Type == room.Type))
                {
                    Rooms.Add(room);
                }
                else
                {
                    Console.WriteLine("Cannot add room!");
                }

            }
            else { Console.WriteLine("Cannot add room!"); }
        }
    }
}
