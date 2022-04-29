using App.Models;

namespace App.Data;
public static class AppDbContextExtensions


{
   
    public static void Seed(this AppDbContext dbContext)
    {
        if (!dbContext.Category.Any())
        {

            var categoriesItems = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Super Car",
                    Description = "Best Cars"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Best Cars",
                    Description = "Best Cars"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Muscle Car",
                    Description = "Best Cars"
                },
                  new Category()
                {
                    Id = 4,
                    Name = "Hyper Car",
                    Description = "Best Cars"
                },
                  new Category()
                {
                    Id = 5,
                    Name = "Japan Race Car",
                    Description = "Best Cars"
                },
                  new Category()
                {
                    Id = 6,
                    Name = "Sport car",
                    Description = "Best Cars"
                },
                  new Category()
                {
                    Id = 7,
                    Name = "German Classics",
                    Description = "Best Cars"
                },
                   new Category()
                {
                    Id = 8,
                    Name = "Italian Classics",
                    Description = "Best Cars"
                },
                new Category()
                {
                    Id = 9,
                    Name = "American Legends",
                    Description = "Best Cars"
                },

            };

            dbContext.Category.AddRange(categoriesItems);
            dbContext.SaveChanges();
        }
        if (!dbContext.Cars.Any())
        {
        var cars = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Name = "Ferrari",
                Brand = "Ferrari",
                Model = "F40",
                ImageUrl = "https://www.ferrari.com/",
                CreationDate = new DateTime(1987, 01, 01),
                LevelPower =7
            },
            new Car()
            {
                Id = 2,
                Name = "Lamborghini",
                Brand = "Lamborghini",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Huracan",
                CreationDate = new DateTime(2014, 01, 01),
                LevelPower =7

            },
            new Car()
            {
                Id = 3,
                Name = "Ford",
                 Brand = "Ford",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Mustang 67’",
                CreationDate = new DateTime(1967, 01, 01),
                LevelPower =3
            },
              new Car()
            {
                Id = 4,
                Name = "Dodge",
                Brand = "Dodge",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Charger R/T 2021",
                CreationDate = new DateTime(2021, 01, 01),
                LevelPower =5

            },
              new Car()
            {
                Id = 5,
                Name = "Pagani",
                 Brand = "Pagani",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Huayra R",
                CreationDate = new DateTime(2018, 01, 01),
                LevelPower =9

            },
              new Car()
            {
                Id = 6,
                Name = "Bugatti",
                 Brand = "Bugatti",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Chiron",
                CreationDate = new DateTime(2019, 01, 01),
                LevelPower =10

            },
              new Car()
            {
                Id = 7,
                Name = "Toyota",
                 Brand = "Toyota",
                ImageUrl = "https://www.ferrari.com/",
                Model = "Supra Yakuza Edition",
                CreationDate = new DateTime(1995, 01, 01),
                LevelPower =7

            },
                new Car()
            {
                Id = 8,
                Name = "Honda",
                 Brand = "Honda",
                ImageUrl = "https://www.ferrari.com/",
                Model = "S2000 Racing",
                CreationDate = new DateTime(2009, 01, 01),
                LevelPower =6

            },
                new Car()
            {
                Id = 9,
                Name = "BMW",
                 Brand = "BMW",
                ImageUrl = "https://www.ferrari.com/",
                Model = "E30",
                CreationDate = new DateTime(1991, 01, 01),
                LevelPower =6

            },
                new Car()
            {
                Id = 10,
                Name = "Porsche",
                 Brand = "Porsche",
                ImageUrl = "https://www.ferrari.com/",
                Model = "911 GT3",
                CreationDate = new DateTime(2007, 01, 01),
                LevelPower =7
            }

        };
        dbContext.Cars.AddRange(cars);
        dbContext.SaveChanges();

        var carcategories = new List<CarCategory>()
        {
            new CarCategory()
            {
                Id = 1,
                CarId = 1,
                CategoryId = 1,
            },
            new CarCategory()
            {
                Id = 2,
                CarId = 1,
                CategoryId = 8
            },
                new CarCategory()
            {
                Id = 3,
                CarId = 2,
                CategoryId = 1
            },
                new CarCategory()
            {
                Id = 4,
                CarId = 3,
                CategoryId = 9
            },
                new CarCategory()
            {
                Id = 5,
                CarId = 3,
                CategoryId = 3
            },
                    new CarCategory()
            {
                Id = 6,
                CarId = 4,
                CategoryId = 3
            },
                    new CarCategory()
            {
                Id = 7,
                CarId = 5,
                CategoryId = 4
            },
                    new CarCategory()
            {
                Id = 8,
                CarId = 6,
                CategoryId = 4
            },
                    new CarCategory()
            {
                Id = 9,
                CarId = 7,
                CategoryId = 5
            },
                    new CarCategory()
            {
                Id = 10,
                CarId = 8,
                CategoryId = 5
            },
                    new CarCategory()
            {
                Id = 11,
                CarId = 8,
                CategoryId = 6
            },
            new CarCategory()
            {
                Id = 12,
                CarId = 9,
                CategoryId = 6
            },
             new CarCategory()
            {
                Id = 13,
                CarId = 9,
                CategoryId = 7
            },
             new CarCategory()
            {
                Id = 14,
                CarId = 10,
                CategoryId = 7
            },
             new CarCategory()
            {
                Id = 15,
                CarId = 10,
                CategoryId = 6
            },
        };
        dbContext.CarCategory.AddRange(carcategories);
        dbContext.SaveChanges();

        }
    }
}