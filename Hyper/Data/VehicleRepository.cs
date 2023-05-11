using Hyper.Models;
namespace Hyper.Data
{
    public class VehicleRepository
    {
        public static List<Vehicle> Cars { get; set; }
        public static List<Vehicle> Boats { get; set; }
        public static List<Vehicle> Buses { get; set; }

        static VehicleRepository()
        {
            Cars = new List<Vehicle>()
            {
                new Car(){Id=1, Color="red", Type="car", Headlights=false, Wheels=4},
                new Car(){Id=2, Color="blue", Type="car", Headlights=false, Wheels=4},
                new Car(){Id=3, Color="black", Type="car", Headlights=false, Wheels=4},
                new Car(){Id=4, Color="white", Type="car", Headlights=false, Wheels=4},
            };
            Boats = new List<Vehicle>()
            {
                new Boat(){Id=5, Color="red", Type="boat"},
                new Boat(){Id=6, Color="blue", Type="boat"},
                new Boat(){Id=7, Color="black", Type="boat"},
                new Boat(){Id=8, Color="white", Type="boat"},
            };
            Buses = new List<Vehicle>()
            {
                new Bus(){Id=9, Color="red", Type="bus"},
                new Bus(){Id=10, Color="blue", Type="bus"},
                new Bus(){Id=11, Color="black", Type="bus"},
                new Bus(){Id=12, Color="white", Type="bus"}
            };
        }
    }
}
