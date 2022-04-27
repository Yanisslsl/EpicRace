using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoriesController(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        // GET: Cars
        public ActionResult Index()
        {
            var categories = _categoryRepository.GetAll();

            var categoryListViewModel = new CategoryListViewModel(
                categories,
                "Liste de courses"
            );

            return View("CategoryList", categoryListViewModel);
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

            return View("CreateCategory");
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCategoryRequest Category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    Category newCategory = new()
                    {
                        Name = Category.Name,
                        Description = Category.Description,
                        ImageUrl = Category.ImageUrl,
                        Color = Category.Color
                    };

                    _categoryRepository.Add(newCategory);
                    _categoryRepository.Commit();

                    return RedirectToAction(nameof(Index));
                }

                return View("CreateCategory");
            }
            catch
            {
                return View("CreateCategory");
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