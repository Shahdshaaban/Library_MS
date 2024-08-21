
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsersApp.Models;
namespace Library_MS.Pages;

public class IndexModel : PageModel
{
    private readonly DB database;
    public List<Book> Books { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger , DB dB)
    {
        _logger = logger;
        database = dB;
    }

    public void OnGet()
    {
        Books = database.GetBooks();
    }

public IActionResult OnPostToggleBorrowed(string title)
{
    var book = database.GetBook(title);
    if (book != null)
    {
        book.IsBorrowed = !book.IsBorrowed;
        var status = book.IsBorrowed ? "unavailable" : "available";

        // Update the book status in your database or application logic here
    }

    return RedirectToPage();
}

}