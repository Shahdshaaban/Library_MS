using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsersApp.Models;

namespace UsersApp.Pages
{
  public class UpdateModel : PageModel{
    [BindProperty(SupportsGet = true)]
    public Book b {get; set;}
    private readonly DB database;
    public UpdateModel (DB d)
    {
        database = d;
    }

    public void OnGet(string Title){
      b = database.GetBook(Title);
      

    }
    public IActionResult OnPost(){
      
      database.UpdateBook(b);
      return RedirectToPage("/index");
    }
    
  }
}

    