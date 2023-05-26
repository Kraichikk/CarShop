using CarShop.Models;

namespace CarShop.Services.Interfaces
{
    public interface IAllMakes
    {
        IEnumerable<Make> AllMakesOfCar { get; }
    }
}
