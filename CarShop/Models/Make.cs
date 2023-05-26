namespace CarShop.Models
{
    public class Make
    {
        public int Id { get; set; }

        public string NameOfMake { get; set; }

        public List<ModelOfCar> Models { get; set; }

        public List<Car> Cars { get; set; }
    }
}
