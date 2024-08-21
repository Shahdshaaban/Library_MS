using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsersApp.Models;

namespace UsersApp.Pages
{
  public class DeleteModel : PageModel
  {
  [BindProperty(SupportsGet = true)]
    public Book b { get; set; }
    private readonly DB database;
    public DeleteModel(DB d)
    {
      database=d;
    }
    public void OnGet(String Title){
        b= database.GetBook(Title);
    }

    public IActionResult OnPost(){
      
      database.DeleteBook(b.Title);
      return RedirectToPage("/index");
    }
    


  }
}