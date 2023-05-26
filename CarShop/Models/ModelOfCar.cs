using CarShop.Models.Enums;

namespace CarShop.Models
{
    public class ModelOfCar
    {
        public int Id { get; set; }

        public string NameOfModel { get; set; }

        public Make Make { get; set; }

        public string Img { get; set; }

        public Color Color { get; set; } // need create color enum     

        public BodyType BodyType { get; set; } // enum
    }
}
