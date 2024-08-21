using System;
namespace UsersApp.Models
{
  public class DB
  {
public List<Book> Books { get; set; }
   
  public DB(){
       Books = new List<Book> 
       {
          new Book {Title="Idiot Brain",Author="Dean Burnett",Genre="scientific",Publication_year="2016"},
          new Book {Title="Psychedelic Outlaws",Author="Joanna Kempner",Genre="non fiction",Publication_year="2024"},
          new Book {Title="Atomic Habits",Author="James Clear",Genre="scientific",Publication_year="2023"},
       };
  }
   
   public List<Book> GetBooks(){
    return Books;
   }

   public void addBook(Book b){
      Books.Add(b);
   }
   public void DeleteBook(string Title){
      Book b = GetBook(Title);
      Books.Remove(b);

   }

   public void UpdateBook(Book UpdatedBook){
      Book b = GetBook(UpdatedBook.Title);
      b.Title = UpdatedBook.Title;
      b.Author = UpdatedBook.Author;
      b.Genre = UpdatedBook.Genre;
      b.Publication_year = UpdatedBook.Publication_year;
   }


   public Book GetBook(string Title){
      return Books.SingleOrDefault(a => a.Title == Title);
      
   }
  }
}