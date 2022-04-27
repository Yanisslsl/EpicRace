using App.Models;

namespace App.ViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> CategoryList { get; }
        public string HeaderTitle { get; }
        public CategoryListViewModel(IEnumerable<Category> categories, string headerTitle)
        {
            CategoryList = categories;
            HeaderTitle = headerTitle;
        }
    }
}