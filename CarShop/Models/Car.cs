namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public Make Make { get; set; }

        public ModelOfCar Model { get; set; }

        public int Odometer { get; set; }

        public string Transmission { get; set; } //enum

        public string EngineType { get; set; } //enum

        public string Condition { get; set; } //enum

        public string InteriorOfCar { get; set; } //enum

        public string WheelDriwe { get; set; } //enum

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
