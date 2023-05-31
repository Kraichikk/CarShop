using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly CarShopDbContext _dbContext;

        public CarController(CarShopDbContext dbContext)
        {
            
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Car> cars = _dbContext.Cars.ToList();
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: /Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(car);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Car");
            }

            return View(car);
        }

        public IActionResult Delete(int id)
        {
            Car car = _dbContext.Cars.Find(id);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
