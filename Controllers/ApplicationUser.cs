using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly IRepository<ApplicationUser> _applicationUserRepository;

        public ApplicationUserController(IRepository<ApplicationUser> applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public ActionResult Index()
        {
            var applicationUsers = _applicationUserRepository.GetAll();

            var usersListViewModel = new UsersListViewModel(
                applicationUsers,
                "Liste de courses"
            );

            return View("UsersList", usersListViewModel);
        }

        // GET: Cars/
        public ActionResult List()
        {
            return Ok("LIST ACTION CALLED !");
        }

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Cars/Create
        public ActionResult Create()
        {

            return View("Edit");
        }

        // POST: Cars/Create
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Create(CreateCarRequest Car)
        // {
        //     try
        //     {
        //         if (ModelState.IsValid)
        //         {
        //             // TODO: Add insert logic here
        //             Car newCar = new()
        //             {
        //                 Name = Car.Name,
        //                 CreationDate = Car.CreationDate,
        //                 Brand = Car.Brand,
        //                 Model = Car.Model,
        //                 CategoryId = Car.CategoryId


        //             };

        //             _applicationUserRepository.Add(newCar);
        //             _applicationUserRepository.Commit();

        //             return RedirectToAction(nameof(Index));
        //         }

        //         return View("CreateCar");
        //     }
        //     catch
        //     {
        //         return View("CreateCar");
        //     }
        // }

        // GET: Cars/Edit/5
        public ActionResult Edit(string id)

        {
            Console.WriteLine("EDIT ACTION CALLED !");
            Console.WriteLine(id);


            Console.WriteLine("EDIT ACTION CALLED !");

            var User = _applicationUserRepository.GetById(id);
            var driver = new EditUserViewModel(
               User
            );
            return View("Edit", driver);
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("EditUserView");
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}