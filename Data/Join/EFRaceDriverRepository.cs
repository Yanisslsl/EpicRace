
using App.Models;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class EFRaceDriverRepository : IRepository<RaceDriver>
    {
        private readonly AppDbContext _dbContext;

        public EFRaceDriverRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public RaceDriver Add(RaceDriver model)
        {
            return _dbContext.RaceDriver.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<RaceDriver> GetAll()
        {
            return _dbContext.RaceDriver.ToList();
        }

        public RaceDriver GetById(int id)
        {
            return _dbContext.RaceDriver.Single(r => r.Id == id);
        }

         public RaceDriver GetById(string id)
        {
            return _dbContext.RaceDriver.Single(r => r.Id == Int32.Parse(id));
        }

        // public Category getCategory(int id)
        // {
        //     return _dbContext.Cars.Include(c => c.Category).Single(r => r.Id == id).Category;
        // }
    }
}