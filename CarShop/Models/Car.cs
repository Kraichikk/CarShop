using CarShop.Models.Enums;

namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string FullName
        {
            get { return Make.Name.ToString() + " " + Model.Name.ToString() + " " + Year.ToString(); }
        }

        public int MakeId { get; set; }

        public Make Make { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set; }

        public int Odometer { get; set; }

        public int EngineDisplacement { get; set; }

        public string Img { get; set; }

        public string Vin { get; set; }

        public Color Color { get; set; } // enum

        public BodyType BodyType { get; set; } // enum

        public Transmission Transmission { get; set; } //enum

        public EngineType EngineType { get; set; } //enum

        public Condition Condition { get; set; } //enum

        public InteriorOfCar InteriorOfCar { get; set; } //enum

        public WheelDriwe WheelDriwe { get; set; } //enum

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
