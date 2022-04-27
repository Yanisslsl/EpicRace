using App.Models;

namespace App.Data
{
    public class EFCategoryRepository : IRepository<Category>
    {
        private readonly AppDbContext _dbContext;

        public EFCategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category Add(Category model)
        {
            return _dbContext.Category.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _dbContext.Category.ToList();
        }

        public Category GetById(int id)
        {
            return _dbContext.Category.Single(r => r.Id == id);
        }
    }
}