
using App.Models;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class EFApplicationUserRepository : IRepository<ApplicationUser>
    {
        private readonly AppDbContext _dbContext;

        public EFApplicationUserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ApplicationUser Add(ApplicationUser model)
        {
            return _dbContext.ApplicationUser.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<ApplicationUser> GetAll()
        {
            return _dbContext.ApplicationUser.Include(c => c.UserCars).ToList();
        }

        public ApplicationUser GetById(int id)
        {
            return _dbContext.ApplicationUser.Single(r => r.Id == id.ToString());
        }

         public ApplicationUser GetById(string id)
        {
            return _dbContext.ApplicationUser.Include(u => u.UserCars).ThenInclude(uc => uc.Car).FirstOrDefault(x => x.Id == id);
        }

        // public Category getCategory(int id)
        // {
        //     return _dbContext.Cars.Include(c => c.Category).Single(r => r.Id == id).Category;
        // }
    }
}