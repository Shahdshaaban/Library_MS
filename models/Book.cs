using System;
namespace UsersApp.Models
{
  public class Book
  {
      public string Title { get; set; }
      public string Author { get; set; }
      public string Genre { get; set; }
      public string Publication_year { get; set; }
      public bool IsBorrowed { get; set; }


  }
}