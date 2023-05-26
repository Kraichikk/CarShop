using CarShop.Models;
using CarShop.Services.Interfaces;
using System.Linq;

namespace CarShop.Services.ModelViews
{
    public class AllCars : IAllCars
    {
        private readonly IAllMakes _makesOfCars = new AllMakes();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                     new Car
                     {
                          Make = GetCurrentMake("Nissan"),
                          Model = GetCurrenModelOfCar(GetCurrentMake("Nissan"), "leaf"),
                          Year = new DateTime(2013),
                          Price = 7000,
                          Odometer = 80000,
                          Transmission = Models.Enums.Transmission.Automatic,
                          EngineType = Models.Enums.EngineType.Electric,
                          Condition = Models.Enums.Condition.Used,
                          InteriorOfCar = Models.Enums.InteriorOfCar.Cloth,
                          WheelDriwe = Models.Enums.WheelDriwe.FrontWheelDrive,
                          IsFavourite = true,
                          Available = true
                          
                         
                     }
                };
            }
        }

        private Make GetCurrentMake(string make)
        {
            foreach (var m in _makesOfCars.AllMakesOfCar)
            {
                if (m.NameOfMake == make)
                {
                    return m;
                }
            }
            return new Make();
        }
        private ModelOfCar GetCurrenModelOfCar(Make make, string model)
        {
            foreach (var m in make.Models)
            {
                if (m.NameOfModel == model)
                {
                    return m;
                }
            }
            return new ModelOfCar();
        }

        IEnumerable<Car> IAllCars.GetFavouriteCars { get; set; }

        Car IAllCars.GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
