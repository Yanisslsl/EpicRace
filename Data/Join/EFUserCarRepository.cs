
using App.Models;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class EFUserCarRepository : IRepository<UserCar>
    {
        private readonly AppDbContext _dbContext;

        public EFUserCarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserCar Add(UserCar model)
        {
            return _dbContext.UserCar.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<UserCar> GetAll()
        {
            return _dbContext.UserCar.ToList();
        }

        public UserCar GetById(int id)
        {
            return _dbContext.UserCar.Single(r => r.UserCarId == id);
        }

         public UserCar GetById(string id)
        {
            return _dbContext.UserCar.Single(r => r.UserCarId == Int32.Parse(id));
        }

        // public Category getCategory(int id)
        // {
        //     return _dbContext.Cars.Include(c => c.Category).Single(r => r.Id == id).Category;
        // }
    }
}