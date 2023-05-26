using CarShop.Models;

namespace CarShop.Services.Interfaces
{
    public interface IAllCars
    {
        public IEnumerable<Car> Cars { get; /*set;*/ }

        public IEnumerable<Car> GetFavouriteCars { get; set; }

        public Car GetCarById(int carId);
    }
}
