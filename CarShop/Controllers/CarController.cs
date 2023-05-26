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
            // Отримати список марок для випадаючого списку
            List<Make> makes = _dbContext.Makes.ToList();
            ViewBag.Makes = makes;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                // Створити поле FullName
                car.FullName = car.Make.Name + " " + car.Model.Name + " " + car.Year;

                _dbContext.Cars.Add(car);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            // Отримати список марок для випадаючого списку
            List<Make> makes = _dbContext.Makes.ToList();
            ViewBag.Makes = makes;

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
