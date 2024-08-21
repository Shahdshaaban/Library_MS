using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsersApp.Models;

namespace UsersApp.Pages
{
    public class ReadModel : PageModel
    {
        private readonly DB _database;

        public Book b { get; set; }

        public ReadModel(DB database)
        {
            _database = database;
        }

        public void OnGet(string Title)
        {
            b = _database.GetBook(Title);
        }

        public IActionResult OnPostToggleBorrowed(string Title)
        {
            var book = _database.GetBook(Title);
            if (book != null)
            {
                book.IsBorrowed = !book.IsBorrowed; // Toggle the borrowed status
                _database.UpdateBook(book); // Ensure the update method is available
                // _database.SaveChanges(); // Uncomment if you have SaveChanges method
            }

          return RedirectToPage("/index");
        }
    }
}
