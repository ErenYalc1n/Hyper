using Microsoft.AspNetCore.Mvc;
using Hyper.Data;
using Hyper.Models;

namespace Hyper.Controllers
{
    [Route("vehicles")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _vehicle;

        public VehicleController(ILogger<VehicleController> vehicle)
        {
            _vehicle = vehicle;
        }
       
        [HttpGet("cars/{Color}")]
        public IActionResult GetCarByColor([FromRoute(Name ="Color")]string Color)
        {
            var cars = VehicleRepository.Cars.Where(b => b.Color.Equals(Color)).SingleOrDefault();           
            if (cars is null)
            {
                return NotFound("bu renkte araç yok.");
            }               
            return Ok(cars);
        }

        [HttpGet("boats/{Color}")]
        public IActionResult GetBoatByColor([FromRoute(Name = "Color")] string Color)
        {
            var boats = VehicleRepository.Boats.Where(b => b.Color.Equals(Color)).SingleOrDefault();
            if (boats is null)
            {
                return NotFound("bu renkte bot yok.");
            }
            return Ok(boats);
        }

        [HttpGet("buses/{Color}")]
        public IActionResult GetBusByColor([FromRoute(Name = "Color")] string Color)
        {
            var buses = VehicleRepository.Buses.Where(b => b.Color.Equals(Color)).SingleOrDefault();
            if (buses is null)
            {
                return NotFound("bu renkte otobüs yok.");
            }
            return Ok(buses);
        }       

        [HttpPost("cars/{id}/headlights")]
        public IActionResult CarHeadlightsUpdate(int id)
        {
            var car = VehicleRepository.Cars.FirstOrDefault(b => b.Id == id && b is Car) as Car;

            if (car == null)
            {
                return NotFound($"Bu Id'de({id}) araç bulunamadı.");
            }

            car.Headlights = !car.Headlights;

            return Ok($"{id} Id'li aracın headlights'ı {(car.Headlights ? "açıldı." : "kapatıldı.")}");
        }

        [HttpDelete]

        public IActionResult DeleteAllCars()
        {
            VehicleRepository.Cars.Clear();
            return Content("Tüm araçlar silindi.");
        }       
    }
}
