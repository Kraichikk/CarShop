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

           
        }
    }
}
