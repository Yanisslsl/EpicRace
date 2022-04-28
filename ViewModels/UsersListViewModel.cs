using App.Models;

namespace App.ViewModels
{
    public class UsersListViewModel
    {
        public IEnumerable<ApplicationUser> UsersList { get; }
        public string HeaderTitle { get; }
        public UsersListViewModel(IEnumerable<ApplicationUser> users, string headerTitle)
        {
            UsersList = users;
            HeaderTitle = headerTitle;
        }
    }
}