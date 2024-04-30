// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using (ApplicationDbContext context = new ())
//{
//    context.Database.EnsureCreated ();

//    if(context.Database.GetPendingMigrations().Count() > 0)
//    {
//        context.Database.Migrate ();
//    }

//}
//AddBook();
GetAllBooks();
//GetBook();
//Update();
Delete();

async void Delete()
{
    var context = new ApplicationDbContext();
    var Book = await context.Books.FindAsync(1);
    context.Remove(Book);
    await context.SaveChangesAsync();
}

async void Update()
{
    var context = new ApplicationDbContext();
     var Book = await context.Books.FindAsync(2);
    Book.Title = "Milk And Honey";
    await context.SaveChangesAsync();
}

async void AddBook()
{
    var context = new ApplicationDbContext();

    var Book = new Book()
    {
        Title = "Hello", ISBN = "765543344", Price = 1.90m, Publisher_Id = 1
    };
    await context.Books.AddAsync(Book);
    await context.SaveChangesAsync();
}



async void GetAllBooks()
{
    var context = new ApplicationDbContext();
    var books =  await context.Books.OrderBy(u => u.Title).ToListAsync();

    foreach ( var book in books)
    {
        Console.WriteLine(" : "+book.Title+" ISBN :"+book.ISBN);
    }

   
}

 async void GetBook(){

    var context = new ApplicationDbContext();
    //var book = context.Books.FirstOrDefault(u => u.Title == "new Book2");
    var books = await context.Books.Where(u => EF.Functions.Like(u.Title, "%o%")).CountAsync();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"{book.Title} - {book.ISBN}");
    //}

    //Console.WriteLine(books);

}