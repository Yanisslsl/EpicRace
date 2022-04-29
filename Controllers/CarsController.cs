using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class CarsController : Controller
    {
        private readonly IRepository<Car> _carRepository;

        public CarsController(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: Cars
        public ActionResult Index()
        {
            var cars = _carRepository.GetAll();

            var carListViewModel = new CarListViewModel(
                cars,
                "Liste de courses"
            );

            return View("CarList", carListViewModel);
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

            return View("CreateCar");
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCarRequest Car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    Car newCar = new()
                    {
                        Name = Car.Name,
                        CreationDate = Car.CreationDate,
                        Brand = Car.Brand,
                        Model = Car.Model,


                    };

                    _carRepository.Add(newCar);
                    _carRepository.Commit();

                    return RedirectToAction(nameof(Index));
                }

                return View("CreateCar");
            }
            catch
            {
                return View("CreateCar");
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
                return View();
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