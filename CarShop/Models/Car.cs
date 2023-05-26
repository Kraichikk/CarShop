using CarShop.Models.Enums;

namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string FullName
        {
            get { return Make.NameOfMake.ToString() + " " + Model.NameOfModel.ToString() + " " + Year.ToString(); }
        }

        public Make Make { get; set; }

        public ModelOfCar Model { get; set; }

        public int Odometer { get; set; }

        public Transmission Transmission { get; set; } //enum

        public EngineType EngineType { get; set; } //enum

        public Condition Condition { get; set; } //enum

        public InteriorOfCar InteriorOfCar { get; set; } //enum

        public WheelDriwe WheelDriwe { get; set; } //enum

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }

        public int MakeId { get; set; }

        private int year;
        public DateTime Year
        {
            get { return new DateTime(year, 1, 1); }
            set
            {
                if (value.Year >= 1900 && value.Year <= DateTime.Now.Year)
                    year = value.Year;
                else
                    throw new ArgumentOutOfRangeException("Invalid year.");
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentOutOfRangeException("Price must be greater than 0.");
            }
        }
        // public string Color { get; set; } import in model
    }
}
