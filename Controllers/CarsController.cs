using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BasicWebAPI;
using BasicWebAPI.Repository;
using BasicWebAPI.Domain;

namespace BasicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CarsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDTO>>> GetCars()
        {
            return await _context.Cars
                .Select(x => CarToDTO(x))
                .ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return CarToDTO(car);
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, CarDTO car)
        {
            if (id != car.id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cars
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CarDTO>> PostCar(CarDTO car)
        {
            var tempCar = new Car
            {
                Id = car.id,
                Name = car.name,
                Price = car.price,
                Acceleration = car.acceleration,
                Braking = car.braking,
                Year = car.year,
            };

            _context.Cars.Add(tempCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.id }, car);
        }

        /// <summary>
        /// Deletes a specific Car.
        /// </summary>
        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Car>> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return car;
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }

        private static CarDTO CarToDTO(Car car) =>
        new CarDTO
        {
            id = car.Id,
            name = car.Name,
            year = car.Year,
            price = car.Price,
            acceleration = car.Acceleration,
            braking = car.Braking
        };
    }
}
