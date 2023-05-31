using CarShop.Models;
using CarShop.Models.Enums;

namespace CarShop.Data
{
    public class DatabaseInitializer
    {
        private readonly CarShopDbContext _dbContext;

        public DatabaseInitializer(CarShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            SeedData();
        }

        private void SeedData()
        {
            if (_dbContext.Cars.Any() || _dbContext.Makes.Any() || _dbContext.Models.Any())
            {
                return;
            }

            var Nissan = new Make { Name = "Nissan" };
            var BMW = new Make { Name = "BMW" };
            var Mercedes = new Make { Name = "Mercedes" };
            var VolksWagen = new Make { Name = "Wolksvagen" };
            var Renault = new Make { Name = "Renault" };
            var Peugeot = new Make { Name = "Peugeot" };
            var Toyota = new Make { Name = "Toyota" };
            var Porsche = new Make { Name = "Porsche" };
            var Seat = new Make { Name = "Seat" };
            var Citroen = new Make { Name = "Citroen" };
            var Ford = new Make { Name = "Ford" };
            var Dodge = new Make { Name = "Dodge" };
            var Chevrolet = new Make { Name = "Chevrolet" };
            var Tesla = new Make { Name = "Tesla" };
            var Opel = new Make { Name = "Opel" };
            var Jeep = new Make { Name = "Jeep" };
            var KIA = new Make { Name = "KIA" };
            var Honda = new Make { Name = "Honda" };
            var Hyundai = new Make { Name = "Hyundai" };
            var Lexus = new Make { Name = "Lexus" };
            var Mazda = new Make { Name = "Mazda" };
            var Mitsubishi = new Make { Name = "Mitsubishi" };
            var Skoda = new Make { Name = "Skoda" };
            var Volvo = new Make { Name = "Volvo" };
            var Audi = new Make { Name = "Audi" };


            _dbContext.Makes.AddRange(Audi, Volvo, Skoda, Mitsubishi, Mazda, Lexus, Hyundai, Honda, KIA, Jeep, Opel,
                Tesla, Chevrolet, Dodge, Ford, Citroen, Seat, Porsche, Toyota, Peugeot, Renault, VolksWagen, Mercedes, BMW,
                Nissan);
            _dbContext.SaveChanges();

            var A3 = new Model { Name = "A3", MakeId = Audi.Id };
            var A4 = new Model { Name = "A4", MakeId = Audi.Id };
            var A6 = new Model { Name = "A6", MakeId = Audi.Id };
            var Q5 = new Model { Name = "Q5", MakeId = Audi.Id };
            var Q7 = new Model { Name = "Q7", MakeId = Audi.Id };
            var Q8 = new Model { Name = "Q8", MakeId = Audi.Id };
            var TT = new Model { Name = "TT", MakeId = Audi.Id };
            var RS7 = new Model { Name = "RS7", MakeId = Audi.Id };
            var RS6 = new Model { Name = "RS6", MakeId = Audi.Id };


            var Leaf = new Model { Name = "Leaf", MakeId = Nissan.Id };
            var Quashqai = new Model { Name = "Quashqai", MakeId = Nissan.Id };
            var Rock = new Model { Name = "Rock", MakeId = Nissan.Id };
            var XTrail = new Model { Name = "XTrail", MakeId = Nissan.Id };

            var X5 = new Model { Name = "X5", MakeId = BMW.Id };
            var X6 = new Model { Name = "X6", MakeId = BMW.Id };
            var X7 = new Model { Name = "X7", MakeId = BMW.Id };
            var M2 = new Model { Name = "M2", MakeId = BMW.Id };
            var M3 = new Model { Name = "M3", MakeId = BMW.Id };
            var M4 = new Model { Name = "M4", MakeId = BMW.Id };
            var M5 = new Model { Name = "M5", MakeId = BMW.Id };
            var M6 = new Model { Name = "M6", MakeId = BMW.Id };
            var M8 = new Model { Name = "M8", MakeId = BMW.Id };
            var Series3 = new Model { Name = "3 Series", MakeId = BMW.Id };
            var Series5 = new Model { Name = "5 Series", MakeId = BMW.Id };
            var Series7 = new Model { Name = "7 Series", MakeId = BMW.Id };

            var AClass = new Model { Name = "A Class", MakeId = Mercedes.Id };
            var SClass = new Model { Name = "S Class", MakeId = Mercedes.Id };
            var EClass = new Model { Name = "EClass", MakeId = Mercedes.Id };
            var GLE = new Model { Name = "GLE", MakeId = Mercedes.Id };

            var GOLF = new Model { Name = "GOLF", MakeId = VolksWagen.Id };
            var Tiguan = new Model { Name = "Tiguan", MakeId = VolksWagen.Id };
            var Touran = new Model { Name = "Touran", MakeId = VolksWagen.Id };
            var TRock = new Model { Name = "T-Rock", MakeId = VolksWagen.Id };
            var Transporter = new Model { Name = "Transporter", MakeId = VolksWagen.Id };
            var Polo = new Model { Name = "Polo", MakeId = VolksWagen.Id };
            var Crafter = new Model { Name = "Crafter", MakeId = VolksWagen.Id };

            var Megane = new Model { Name = "Megane", MakeId = Renault.Id };
            var Duster = new Model { Name = "Duster", MakeId = Renault.Id };
            var Kadjar = new Model { Name = "Kadjar", MakeId = Renault.Id };
            var Logan = new Model { Name = "Logan", MakeId = Renault.Id };

            var m3008 = new Model { Name = "3008", MakeId = Peugeot.Id };
            var m5008 = new Model { Name = "5008", MakeId = Peugeot.Id };
            var m308 = new Model { Name = "308", MakeId = Peugeot.Id };
            var m508 = new Model { Name = "508", MakeId = Peugeot.Id };

            var rav4 = new Model { Name = "rav4", MakeId = Toyota.Id };
            var Camry = new Model { Name = "Camry", MakeId = Toyota.Id };
            var Highlander = new Model { Name = "Highlander", MakeId = Toyota.Id };
            var LandCruiser = new Model { Name = "Land Cruiser", MakeId = Toyota.Id };

            var Cayenne = new Model { Name = "Cayenne", MakeId = Porsche.Id };
            var Macan = new Model { Name = "Macan", MakeId = Porsche.Id };
            var Panamera = new Model { Name = "Panamera", MakeId = Porsche.Id };
            var m911 = new Model { Name = "911", MakeId = Porsche.Id };

            var Toledo = new Model { Name = "Toledo", MakeId = Seat.Id };

            var DS3 = new Model { Name = "DS-3", MakeId = Citroen.Id };
            var DS4 = new Model { Name = "DS-4", MakeId = Citroen.Id };
            var DS5 = new Model { Name = "DS-5", MakeId = Citroen.Id };
            var C4 = new Model { Name = "C4", MakeId = Citroen.Id };

            var Kuga = new Model { Name = "Kuga", MakeId = Ford.Id };
            var Focus = new Model { Name = "Focus", MakeId = Ford.Id };
            var Mustang = new Model { Name = "Mustang", MakeId = Ford.Id };
            var Mondeo = new Model { Name = "Mondeo", MakeId = Ford.Id };
            var F150 = new Model { Name = "F150", MakeId = Ford.Id };

            var Dart = new Model { Name = "Dart", MakeId = Dodge.Id };
            var Charger = new Model { Name = "Charger", MakeId = Dodge.Id };
            var Challenger = new Model { Name = "Challenger", MakeId = Dodge.Id };
            var RAM = new Model { Name = "RAM", MakeId = Dodge.Id };

            var Volt = new Model { Name = "Volt", MakeId = Chevrolet.Id };

            var Model3 = new Model { Name = "Model 3", MakeId = Tesla.Id };
            var ModelS = new Model { Name = "Model S", MakeId = Tesla.Id };
            var ModelX = new Model { Name = "Model X", MakeId = Tesla.Id };
            var ModelY = new Model { Name = "Model Y", MakeId = Tesla.Id };

            _dbContext.Models.AddRange(
                A3, A4, A6, Q5, Q7, Q8, TT, RS7, RS6, Leaf, Quashqai, Rock, XTrail, X5, X6, X7, M2, M3, M4, M5, M6, M8,
                Series3, Series5, Series7, AClass, SClass, EClass, GLE, GOLF, Tiguan, Touran, TRock, Transporter, Polo,
                Crafter, Megane, Duster, Kadjar, Logan, m3008, m5008, m308, m508, rav4, Camry, Highlander, LandCruiser,
                Cayenne, Macan, Panamera, m911, Toledo, DS3, DS4, DS5, C4, Kuga, Mustang, Mondeo, Focus, F150, Dart,
                Challenger, Charger, RAM, Volt, Model3, ModelS, ModelX, ModelY
            );
            _dbContext.SaveChanges();

            var car1 = new Car
            {
                MakeId = Audi.Id,
                ModelId = Q8.Id,
                Year = new DateTime(2023),
                Price = 116000,
                Odometer = 0,
                Transmission = Transmission.Automatic,
                EngineType = EngineType.Diesel,
                EngineDisplacement = 3000,
                Condition = Condition.New,
                InteriorOfCar = InteriorOfCar.Leather,
                WheelDriwe = WheelDriwe.AllWheelDrive,
                Img = $"/CarsIMG/Audi/Q8/Black",
                Color = Color.Black,
                BodyType = BodyType.SUV
            };

            _dbContext.Cars.AddRange();
        }
    }
}
