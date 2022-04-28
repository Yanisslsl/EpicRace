
using App.Models;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class EFCarRepository : IRepository<Car>
    {
        private readonly AppDbContext _dbContext;

        public EFCarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Car Add(Car model)
        {
            return _dbContext.Cars.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<Car> GetAll()
        {
            return _dbContext.Cars.Include(c => c.Category).ToList();
        }

        public Car GetById(int id)
        {
            return _dbContext.Cars.Single(r => r.Id == id);
        }

         public Car GetById(string id)
        {
            return _dbContext.Cars.Single(r => r.Id == Int32.Parse(id));
        }

        public Category getCategory(int id)
        {
            return _dbContext.Cars.Include(c => c.Category).Single(r => r.Id == id).Category;
        }
    }
}