namespace Hyper.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Color { get; set; }

        public string Type { get; set; }
    }

    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        public bool Headlights { get; set; }
    }
    public class Boat : Vehicle
    {
        
    }
    public class Bus : Vehicle
    {
        
    }
}
