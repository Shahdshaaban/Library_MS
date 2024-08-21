using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsersApp.Models;

namespace UsersApp.Pages
{
  public class AddModel : PageModel{

    private readonly DB database;
    public AddModel (DB d)
    {
        database = d;
    }
    
    [BindProperty]
    public Book b { get; set; }


    
    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        database.addBook(b);
        return RedirectToPage("/index");
    }
  }
}