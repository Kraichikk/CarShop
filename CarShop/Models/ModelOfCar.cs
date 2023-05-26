\namespace CarShop.Models
{
    public class ModelOfCar
    {
        public int Id { get; set; }

        public Make Make { get; set; }

        public string Img { get; set; }

        public string Color { get; set; } // need create color enum

        public string ComfortLevel { get; set; } //enum
    }
}
