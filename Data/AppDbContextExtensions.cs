using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void Seed(this AppDbContext dbContext)
    {
        if (!dbContext.ResultItem.Any())
        {

            var resultItems = new List<ResultItem>()
            {
                new ResultItem()
                {
                    Id = 1,
                    DriverName = "Jean Louis",
                    Rank = 1
                },
                new ResultItem()
                {
                    Id = 2,
                    DriverName = "Jean Claude",
                    Rank = 2
                },
                new ResultItem()
                {
                    Id = 3,
                    DriverName = "Jean Jean",
                    Rank = 3
                }
            };

            dbContext.ResultItem.AddRange(resultItems);
            dbContext.SaveChanges();
        }
        // if (!dbContext.ResultItem.Any())
        // {
        // var cars = new List<Car>()
        // {
        //     new Car()
        //     {
        //         Id = 1,
        //         Name = "Ferrari",
        //         Brand = "Ferrari",
        //         Model = "Ferrari",
        //         ImageUrl = "https://www.ferrari.com/",

        //         CreationDate = new DateTime(2020, 01, 01)
        //     },
        //     new Car()
        //     {
        //         Id = 2,
        //         Name = "Lamborghini",
        //          Brand = "Ferrari",
        //         ImageUrl = "https://www.ferrari.com/",
        //         Model = "Ferrari",


        //         CreationDate = new DateTime(2020, 01, 01)
        //     },
        //     new Car()
        //     {
        //         Id = 3,
        //         Name = "Bugatti",
        //          Brand = "Ferrari",
        //         ImageUrl = "https://www.ferrari.com/",

        //         Model = "Ferrari",

        //         CreationDate = new DateTime(2020, 01, 01)
        //     }
        // };
        // dbContext.Cars.AddRange(cars);
        // dbContext.SaveChanges();
        // }
    }
}